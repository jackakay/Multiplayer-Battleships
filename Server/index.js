const express = require('express');
const app = express();
const PORT = 8080;
const games = [];
app.use(express.json());

app.get('/begin', (req, res) =>{
    res.status(200).send({
        "text": "ok"
    })
});

app.post('/creategame', (req,res) => {
    const game_Name = req.body.Text;
    if(!games.includes(game_Name)){
        games.push(game_Name);
        res.status(201).json({message: 'Success'});
        console.log("Game create with name " + game_Name);
    }else{
        res.status(409).json({mesagge: 'Failure'});
    }
})

app.get('/getGameBoard', (req, res) =>{
    res.status(200).send({
        "text": "ok",
        "p1hits": ["11", "23", "98"],
        "p1misses": ["00", "55", "34"],
        "p2hits": ["11", "23", "98"],
        "p2misses": ["00", "55", "34"],
    })
});


app.listen(
    PORT,
    () => console.log('Alive')
    );