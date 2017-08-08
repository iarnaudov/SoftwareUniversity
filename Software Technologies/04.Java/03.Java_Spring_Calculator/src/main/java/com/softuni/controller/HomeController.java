package com.softuni.controller;

import com.softuni.entity.Calculator;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;

@Controller
public class HomeController {
	@GetMapping("/")
	public String index(Model model) {
		model.addAttribute("operator", "+");
		model.addAttribute("view","views/calculatorForm");
		return "base-layout";
	}

	@PostMapping("/")
	public String calculate(Model model, Calculator calculator) {
		model.addAttribute("operator", calculator.getOperator());
		model.addAttribute("rightOperand", calculator.getRightOperand());
		model.addAttribute("leftOperand", calculator.getLeftOperand());
		model.addAttribute("result", calculator.calculateResult());
		model.addAttribute("view","views/calculatorForm");
		return "base-layout";
	}
}
