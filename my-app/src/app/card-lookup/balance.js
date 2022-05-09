function checkBalance(cardNum){
    this.balance = '654321123456';
    const configUrl = 'get/api/card/' + this.cardNum;
    const response = await fetch(configUrl);
    this.balance= JSON.stringify(response); 
    return this.balance;
  }