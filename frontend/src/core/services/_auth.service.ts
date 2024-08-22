import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root', // Service is available globally
})
export class AuthService {
  private tokenKey = 'authToken';

  constructor(private http: HttpClient, private router: Router) {}

  login(credentials: { email: string, password: string }) {
    return this.http.post<{ token: string }>('API_URL/login', credentials)
      .subscribe(response => {
        localStorage.setItem(this.tokenKey, response.token);
        this.router.navigate(['/dashboard']); // Redirect to a protected route
      });
  }

  logout() {
    localStorage.removeItem(this.tokenKey);
    this.router.navigate(['/login']);
  }

  getToken() {
    return localStorage.getItem(this.tokenKey);
  }

  isAuthenticated(): boolean {
    return !!this.getToken(); // Returns true if there's a token
  }
}
