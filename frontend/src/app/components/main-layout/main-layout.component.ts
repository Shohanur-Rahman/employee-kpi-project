import { AfterViewInit, Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';

declare var $: any;

@Component({
  selector: 'app-main-layout',
  standalone: true,
  imports: [RouterOutlet],
  templateUrl: './main-layout.component.html',
  styleUrl: './main-layout.component.css'
})
export class MainLayoutComponent implements AfterViewInit {
  ngAfterViewInit() {
    this.addFont('https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700&amp;display=swap');
    this.loadCss('assets/css/app.min.css');
    this.loadScript('assets/js/app.js');
    $("body").attr("data-sidebar", "dark");
  }

  addFont(fontUrl: string) {
    const link = document.createElement('link');
    link.rel = 'stylesheet';
    link.href = fontUrl;
    link.onload = () => {
      console.log(`Font loaded successfully: ${fontUrl}`);
    };
    link.onerror = () => {
      console.error(`Error loading font: ${fontUrl}`);
    };
    document.head.appendChild(link);
  }

  loadCss(cssUrl: string) {
    const link = document.createElement('link');
    link.rel = 'stylesheet';
    link.href = cssUrl;
    link.onload = () => {
      console.log(`${cssUrl} loaded successfully.`);
    };
    link.onerror = () => {
      console.error(`Error loading CSS: ${cssUrl}`);
    };
    document.head.appendChild(link);
  }

  loadScript(scriptUrl: string) {
    const script = document.createElement('script');
    script.src = scriptUrl;
    script.onload = () => {
      console.log(`${scriptUrl} loaded successfully.`);
      // You can call any functions defined in the loaded script here
    };
    script.onerror = () => {
      console.error(`Error loading script: ${scriptUrl}`);
    };
    document.body.appendChild(script);
  }
}
