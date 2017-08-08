<?php

namespace SoftUniBlogBundle\Controller;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Route;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Method;
use Sensio\Bundle\FrameworkExtraBundle\Configuration\Security;
use SoftUniBlogBundle\Entity\Article;
use SoftUniBlogBundle\Form\ArticleType;
use Symfony\Bundle\FrameworkBundle\Controller\Controller;
use Symfony\Component\HttpFoundation\Request;

class ArticleController extends Controller
{
    /**
     * @Route("/articles/create",name="article_create")
     * @Security("is_granted('IS_AUTHENTICATED_FULLY')")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function create(Request $request)
    {
        $article = new Article();
        $form = $this->createForm(ArticleType::class, $article);
        $form->handleRequest($request);

        $loggedUser = $this->getUser();

        if ($form->isValid()) {
            $article->setAuthor($loggedUser);
            $entityManager = $this->getDoctrine()->getManager();
            $entityManager->persist($article);
            $entityManager->flush();
        }
        return $this->render
        ('articles/create.html.twig',
            [
                'form' => $form->createView()
            ]
    );
    }

    /**
     * @return \Symfony\Component\HttpFoundation\Response
     * @Route ("/articles/list", name="article_list")
     */
    public function listArticles()
    {
        $articleRepository = $this->getDoctrine()
            ->getRepository(Article::class);
        $allArticles = $articleRepository->findAll();
        return $this->render("articles/list.html.twig",
            [
                'articles' => $allArticles
            ]
        );

    }
    /**
     * @return \Symfony\Component\HttpFoundation\Response
     * @Route ("/articles/mine", name="my_articles")
     */
    public function MyArticles()
    {

        /** @var $loggedUser */
        $loggedUser = $this->getUser();
        $allArticles = $loggedUser->getArticles();
        return $this->render("articles/list.html.twig",
            [
                'articles' => $allArticles
            ]
        );
    }

    /**
     * @param $id
     * @Route("/articles/{id}",name="show_article")
     * @return \Symfony\Component\HttpFoundation\Response
     */
    public function show($id)
    {
        $articleRepository = $this->getDoctrine()->getRepository(Article::class);
        $article = $articleRepository->find($id);
        return $this->render('articles/show.html.twig',
            [
                'article' => $article
            ]);
    }


}
