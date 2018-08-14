import { Component } from '@angular/core';
declare var CefSharp: any;
declare var jsWrapper: any;
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  title = 'WebApp';

  lines: Array<string>;

  editorOptions = {theme: 'vs-dark', language: 'javascript'};
  code: string= 'function x() {\nconsole.log("Hello world!");\n}';

  btnClick(): void {
    // alert(jsWrapper)
    // alert(jsWrapper.LoadCatalog());
    CefSharp.BindObjectAsync("jsWrapper").then((result) => {
      //console.log((<any>window).jsWrapper);
      (<any>window).jsWrapper.loadCatalog('CefSharp').then((res) => {
        this.lines = res;
      });
    });
  }

}
