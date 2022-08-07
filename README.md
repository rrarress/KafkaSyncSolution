# KafkaSyncSolution
![KafkaSyncDiagramBetweenTwoSqlDb](https://user-images.githubusercontent.com/18008819/183292567-90a782ad-36cc-462a-b32a-97dedd9b15ac.jpg)
1. Download the images required for Kafka using the docker compose file from /KafkaServer by running the command  "docker-compose up -d"
  1a. ![DockerImages](https://user-images.githubusercontent.com/18008819/183292463-5de33b03-eadc-4b32-9832-aa490cc1a665.jpg)
2. Enable Database/Table for CDC template (https://docs.microsoft.com/en-us/sql/relational-databases/track-changes/enable-and-disable-change-data-capture-sql-server?view=sql-server-ver15)
3. Create and configure the Kafka Sql Connector. (https://hevodata.com/learn/connect-apache-kafka-to-sql-server/#s1)
  3a. ![CreateConnectorUsingConfluentUI](https://user-images.githubusercontent.com/18008819/183292493-444569d7-989e-4761-8774-10dd214ce9f9.jpg)
  3b.![CreateConnectorUsingPostman](https://user-images.githubusercontent.com/18008819/183292513-8d5053db-6c38-42b1-b0c4-6696080dcfe4.jpg)
4. Create and start a consumer for the topic/topics of the created connector.
  4a. ![KafksConsumer](https://user-images.githubusercontent.com/18008819/183292543-b0842281-2ae9-4dc1-bd27-a8a3a9ec606b.jpg)
5. Insert/Update/Delete some date on the monitored sql database/table.
6. Observe the traffic on the Kafka topic and view the modified data in the consumer application.
  6a. ![ProducerConsumer](https://user-images.githubusercontent.com/18008819/183292536-33893b1e-54fc-4c98-b541-9cfb81ace5da.jpg)
