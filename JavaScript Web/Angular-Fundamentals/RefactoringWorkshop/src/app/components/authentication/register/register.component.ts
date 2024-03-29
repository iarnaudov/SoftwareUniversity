import { ToastrService } from 'ngx-toastr';
import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../../../core/services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @ViewChild('f') registerForm: NgForm;

  constructor(
    private authService: AuthService,
    private router: Router,
    private toastr: ToastrService
  ) { }

  ngOnInit() {
  }

  register() {
    if (this.registerForm.value['password'] !== this.registerForm.value['repeatPass']) {
      this.toastr.error('Passwords must match');
    }

    this.authService
      .signUp(this.registerForm.value)
      .subscribe((data) => {
        console.log(data);
        this.router.navigate(['/login']);
      });
  }
}
