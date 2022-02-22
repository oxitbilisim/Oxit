import { INavData } from "@coreui/angular";

export const navItems: INavData[] = [
  {
    name: "Dashboard",
    url: "/dashboard",
    icon: "icon-speedometer",
  },
  {
    name: "Buttons",
    url: "/buttons",
    icon: "icon-cursor",
    children: [
      {
        name: "Buttons",
        url: "/buttons/buttons",
        icon: "icon-cursor",
      },

    ],
  },
];
