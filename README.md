# Endpoints:
## GET
### http://localhost:5241/api/produto

## GET By ID
http://localhost:5241/api/produto/{id}

## PUT
###http://localhost:5241/api/produto/{id}

example:
    {
        "id": 1,
        "descricao": "Smartphone Samsung Galaxy S23 - 128GB",
        "preco": 5000.99,
        "dataValidade": "2025-12-31T00:00:00"
    }
	
## POST
### http://localhost:5241/api/produto

example:
    {
        "descricao": "A Smartphone Teste",
        "preco": 10.5,
        "dataValidade": "2025-12-31T00:00:00"
    }
	
## DELETE
### http://localhost:5241/api/produto/{id}
