import { useEffect, useState } from 'react';
import './App.css';

interface Connection {
    date: string;
    summary: string;
}

function App() {
    const [connectionList, setConnectionList] = useState<Connection[]>();

    useEffect(() => {
        getConnectionList();
    }, []);

    const contents = connectionList === undefined
        ? <p>Loading...</p>
        : <table className="table table-striped" aria-labelledby="tabelLabel">
            <thead>
                <tr>
                    <th>Date</th>
                    <th>Summary</th>
                </tr>
            </thead>
            <tbody>
                {connectionList.map(connection =>
                    <tr key={connection.date}>
                        <td>{connection.summary}</td>
                    </tr>
                )}
            </tbody>
        </table>;

    return (
        <div>
            <h1 id="tabelLabel">Connections</h1>
            {contents}
        </div>
    );

    async function getConnectionList() {
        fetch('/api/v1/connection-list/get-connections', {
            method: 'GET',
            headers: {
                "Accept": "application/json",
                'Content-Type': 'application/json'
            }
        })
            .then(response => { return response.json(); })
            .then(data => setConnectionList(data))
            .catch(err => {
                console.log("fetch error" + err);
            });
    }
}

export default App;