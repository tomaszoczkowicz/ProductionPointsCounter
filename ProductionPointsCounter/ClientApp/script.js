const h1 = document.querySelector('h1')
const pointsbody = document.querySelector('.points-body')
const tbody = document.querySelector('.orders-body')
const URL = 
'https://localhost:7166/api/desktop'

let date = new Date().toJSON().slice(0, 10)
h1.textContent = `Produkcja na dzień: ${date}`

async function getOrders() {
    let orders
    let productionPoints
    let completedPoints
    let percentageCompleted
     await axios.get(URL).then(res => 
        {
            orders = res.data.orderList
            productionPoints = res.data.plannedPoints
            completedPoints = res.data.completedPoints
        })
    percentageCompleted = ((completedPoints/productionPoints)*100).toFixed()

    // console.log(orders);
    // console.log(productionPoints);
    // console.log(completedPoints);
     console.log(percentageCompleted);

    const pointsTr = document.createElement('tr')
    const completedPointsTd = document.createElement('td')
    completedPointsTd.textContent = completedPoints 
    pointsTr.appendChild(completedPointsTd)   
    const plannedPointsTd = document.createElement('td')
    plannedPointsTd.textContent = productionPoints   
    pointsTr.appendChild(plannedPointsTd)
    const percentagePointsTd = document.createElement('td')
    percentagePointsTd.textContent = percentageCompleted+"%"  
    pointsTr.appendChild(percentagePointsTd)
    pointsbody.appendChild(pointsTr)

    orders.forEach(element => {
        const tr = document.createElement('tr')
        const tdOrder = document.createElement('td')
        tdOrder.textContent = element.orderName
        tr.appendChild(tdOrder)
        const tdStatus = document.createElement('td')
        tdStatus.textContent = element.status
        tr.appendChild(tdStatus)
        const tdPoints = document.createElement('td')
        tdPoints.textContent = element.productionPoints
        tr.appendChild(tdPoints)
        tbody.appendChild(tr)
    });

}
getOrders()
//setInterval(getOrders, 10000)