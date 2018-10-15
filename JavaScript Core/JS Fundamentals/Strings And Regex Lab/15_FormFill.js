function formFill(username, email, phone, form) {
    for (let i = 0; i < form.length; i++) {
        form[i] = form[i].replace(/<![A-Za-z]+!>/g, username).replace(/<@[A-Za-z]+@>/g, email).replace(/<\+[A-Za-z]+\+>/g, phone);
    }
    console.log(form.join("\n"));
}

// formFill('Pesho',
//     'pesho@softuni.bg',
//     '90-60-90', ['Hello, <!username!>!',
//         'Welcome to your Personal profile.',
//         'Here you can modify your profile freely.',
//         'Your current username is: <!fdsfs!>. Would you like to change that? (Y/N)',
//         'Your current email is: <@DasEmail@>. Would you like to change that? (Y/N)',
//         'Your current phone number is: <+number+>. Would you like to change that? (Y/N)'
//     ]
// )