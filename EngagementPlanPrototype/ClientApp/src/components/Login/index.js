import { Input, Button } from "antd";
import React, { useEffect, useState } from "react";
import "./login.css";
import { useNavigate } from "react-router-dom";

function Login(props) {
  const [isLoading, setIsLoading] = useState(false);
  const [teamName, setteamName] = useState("");
  const navigate = useNavigate();

  function onFinish(values) {
    sessionStorage.setItem("teamName", teamName);
    setIsLoading(true);
    navigate("/home");
  }
  return (
    <div>
      {isLoading ? (
        ""
      ) : (
        <div
          style={{
            display: "flex",
            justifyContent: "center",
            alignItems: "center",
            height: "50vh",
            paddingInline: "5rem",
          }}
        >
          <div>
            <Input
              placeholder="Enter Team Name"
              defaultValue={teamName}
              onChange={(e) => {
                setteamName(e.target.value);
              }}
              style={{ marginTop: "1rem" }}
            />
            {/* <Input
              placeholder="Enter Employee Name"
              defaultValue={empName}
              onChange={(e) => {
                setEmpName(e.target.value);
              }}
              style={{ marginTop: "1rem" }}
            /> */}
            <Button
              type="primary"
              onClick={onFinish}
              style={{
                marginTop: "1rem",
                backgroundColor: "#27a6a4",
              }}
            >
              Start
            </Button>
          </div>
        </div>
      )}
    </div>
  );
}

export default Login;
