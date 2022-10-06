// const express = require('express')
import express from 'express'

// create express server
const app = express()

const cors = require('cors')

const dotenv = require('dotenv')
dotenv.config()

app.use(cors())
app.use(express.json())
app.use(express.urlencoded({ extended : false }))
