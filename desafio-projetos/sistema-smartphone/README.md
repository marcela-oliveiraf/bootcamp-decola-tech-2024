# Sistema de Smartphone

Este é um desafio de projeto do Bootcamp Decola Tech Avanade 2024 da plataforma [DIO](https://www.dio.me/).

## Proposta

Implementar um sistema de smartphone de acordo com o diagrama a seguir:

![Diagrama de classe smartphone](diagrama-classe-smartphone.png)

---
## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo
