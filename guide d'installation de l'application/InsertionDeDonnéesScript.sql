INSERT INTO administrators (`pseudo`,`password`) VALUES ('admin', 'Pa$$w0rd');
INSERT INTO brands (`name`) VALUES ('ASUS');
INSERT INTO brands (`name`) VALUES ('HP');
INSERT INTO brands (`name`) VALUES ('DELL');
INSERT INTO brands (`name`) VALUES ('MSI');
INSERT INTO brands (`name`) VALUES ('ACER');
INSERT INTO modules (`name`) VALUES ('ICT-146');
INSERT INTO modules (`name`) VALUES ('ICT-160');
INSERT INTO modules (`name`) VALUES ('MA-02');
INSERT INTO modules (`name`) VALUES ('MA-30');
INSERT INTO storageplaces (`name`) VALUES ('sc-c111');
INSERT INTO storageplaces (`name`) VALUES ('sc-c236');
INSERT INTO types (`name`) VALUES ('pc');
INSERT INTO types (`name`) VALUES ('écran');
INSERT INTO types (`name`) VALUES ('clavier');
INSERT INTO types (`name`) VALUES ('souris');
INSERT INTO types (`name`) VALUES ('switch');
INSERT INTO types (`name`) VALUES ('routeur');
INSERT INTO materials (`name`, `description`, `date of purchase`, `brand_id`, `module_id`, `storage place_id`, `renewal DATE`, quantity, `type_id`, archived) VALUES ('pc02', 'pc de tristan','2023-05-22','3', '2', '2', '2023-06-30', '1', '1', '0');
INSERT INTO materials (`name`, `description`, `date of purchase`, `brand_id`, `module_id`, `storage place_id`, `renewal DATE`, quantity, `type_id`, archived) VALUES ('pc04', 'pc de pablo','2023-05-22','3', '2', '2', '2023-05-25', '1', '1', '1');
INSERT INTO materials (`name`, `description`, `date of purchase`, `brand_id`, `module_id`, `storage place_id`, `renewal DATE`, quantity, `type_id`, archived) VALUES ('clavier-02', 'clavier de tristan','2023-05-22','3', '2', '2', '2023-06-30', '1', '3', '0');
INSERT INTO materials (`name`, `description`, `date of purchase`, `brand_id`, `module_id`, `storage place_id`, `renewal DATE`, quantity, `type_id`, archived) VALUES ('clavier-04', 'clavier de pablo','2023-05-22','3', '2', '2', '2023-06-30', '1', '3', '0');
INSERT INTO materials (`name`, `description`, `date of purchase`, `brand_id`, `module_id`, `storage place_id`, `renewal DATE`, quantity, `type_id`, archived) VALUES ('souris-02', 'souris de tristan','2023-05-22','5', '2', '2', '2023-06-30', '1', '4', '1');
INSERT INTO materials (`name`, `description`, `date of purchase`, `brand_id`, `module_id`, `storage place_id`, `renewal DATE`, quantity, `type_id`, archived) VALUES ('switchs', 'switchs dans la salle c111','2023-05-20','2', '1', '1', '2023-07-30', '12', '5', '0');
INSERT INTO materials (`name`, `description`, `date of purchase`, `brand_id`, `module_id`, `storage place_id`, `renewal DATE`, quantity, `type_id`, archived) VALUES ('routeurs', 'routeurs dans la salle c111','2023-05-22','4', '3', '2', '2023-06-30', '12', '6', '0');
INSERT INTO materials (`name`, `description`, `date of purchase`, `brand_id`, `module_id`, `storage place_id`, `renewal DATE`, quantity, `type_id`, archived) VALUES ('écrans', 'écrans dans la salle c236','2023-05-22','5', '4', '1', '2023-06-30', '16', '2', '0');
INSERT INTO modifications (`modification`,`date`,`material_id`) VALUE ('changement de PC03 à PC02', '2023-05-23', 1);
INSERT INTO modifications (`modification`,`date`,`material_id`) VALUE ('changement de PC04 à PC02', '2023-05-20', 1);
INSERT INTO modifications (`modification`,`date`,`material_id`) VALUE ('changement de clavier03 à clavier02', '2023-05-23', 2);