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
      {
        name: "Dropdowns",
        url: "/buttons/dropdowns",
        icon: "icon-cursor",
      },
      {
        name: "Brand Buttons",
        url: "/buttons/brand-buttons",
        icon: "icon-cursor",
      },
    ],
  },
];
