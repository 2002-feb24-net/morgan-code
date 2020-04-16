import CardService from "./card-service";
import Page from "./page";

const cardService = new CardService();
const page = new Page(cardService);
page.run();