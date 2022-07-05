const p = document.querySelector('p')
const tbody = document.querySelector('tbody')
const URL = 
'https://localhost:7166/api/today'

async function getOrders() {
    const response = await axios.get(URL).then(res => res.data)
    console.log(response);
    
    response.forEach(element => {
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

setInterval(getOrders, 10000)