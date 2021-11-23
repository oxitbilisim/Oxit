import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { ButtonsComponent } from "./buttons.component";

const routes: Routes = [
  {
    path: "",
    data: {
      title: "Buttons",
    },
    children: [
      {
        path: "",
        redirectTo: "buttons",
      },
      {
        path: "buttons",
        component: ButtonsComponent,
        data: {
          title: "Buttons",
        },
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ButtonsRoutingModule {}
