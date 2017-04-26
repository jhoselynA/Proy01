CREATE SEQUENCE T_NIVEL_APROB_AI START WITH 1;

CREATE OR REPLACE TRIGGER T_NIVEL_APROB_AI_TRIG
BEFORE INSERT ON T_NIVEL_APROB
FOR EACH ROW
BEGIN
    
    SELECT T_NIVEL_APROB_AI.NEXTVAL
    INTO :new.ID_NIVEL
    FROM dual;

END;