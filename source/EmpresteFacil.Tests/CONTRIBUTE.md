Para gerar novas tabelas no banco será sempre necessário executar as migrations

Para criar uma nova migration baseada nas suas modificações de models, executar os seguintes comandos

```shell
	$ add-migration <migration-name> -Context DatabaseContext -o "Data/Migrations"
```

Para executar uma migration, execute o seguinte comando:

```shell
	$ update-database -Context DatabaseContext
```

Para reverter a criação de uma migration, execute:
```shell
	$ remove-migration -Context DatabaseContext
```