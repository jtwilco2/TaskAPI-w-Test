import { Component, inject, OnInit } from '@angular/core';
import { HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent implements OnInit{
  private http = inject(HttpClient);
  tasks: any[] = [];
  loading = true;

  ngOnInit(): void {
    this.http.get<any[]>('http://localhost:5108/api/tasks').subscribe({
      next: (data) => {
        this.tasks = data;
        this.loading = false;
      },
      error: (err) => {
        console.error('Error fetching tasks:', err);
        this.loading = false;
      }
    });
  }

}
