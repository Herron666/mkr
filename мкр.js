function Task2()
{
    let p = document.getElementById("numbers").value;
    let arr = new arrey();
    for ( i = 0; i < p; i++ )
    {
        var a = Math.round( Math.random() * 100 );
        var arr = arr.push(a);
    }
    document.write( '<br>' + arr);

    let res = document.getElemenyById("result");
    res.innerText = `${arr}`

}