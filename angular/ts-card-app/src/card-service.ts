import Card from "./card";

export default class CardService{
    currentDeckId: string | null = null;

    newDeck(): Promise<void>{
        return fetch('https://deckofcardsapi.com/api/deck/new/',{
           method: 'GET',
           headers:{
               'Accept': 'application/json'
           }
        })
        .then(response => response.json())
        .then(responseObj => {
            this.currentDeckId = responseObj.deck_id;
            console.log(this.currentDeckId);
        });
    }

    drawCard(): Promise<void>{

        throw new Error("Method not implemented.");
    }
}