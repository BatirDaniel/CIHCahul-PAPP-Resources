const galerie = document.getElementById('galerie')

const getImages = async () => {
  const url = `https://jsonplaceholder.typicode.com/photos`
  const res = await fetch(url)
  const data = await res.json()
  return data
}

const displayImages = async () =>{
  const images = await getImages()
  const myImages = images.filter((img,i) => i<100)

  let contor=0
  const int = setInterval(()=>{
      galerie.innerHTML += `<img src='${myImages[contor].url}' class='images'>`
      contor++;
      if (contor >= 100) clearInterval(int)
  },1000)
}
displayImages()