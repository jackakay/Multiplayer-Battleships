const app = require('express')();
const PORT = 8080;

app.get('/begin', (req, res) =>{
    res.status(200).send({
        "text": "ok"
    })
});

app.post("/send/:id", (req, res) => {
    const {id} = req.params;
})

app.listen(
    PORT,
    () => console.log('Alive')
    );