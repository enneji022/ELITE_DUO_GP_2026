# ELITE DUO Group Practical 2026 — Water Management System

## Team
- Sibuyi, EL
- Banda, I

## About This Project

This application was built as part of a group practical assignment requiring the design and development of a Visual Basic application addressing one of the seventeen United Nations Sustainable Development Goals (SDGs). The application was required to demonstrate, at minimum, composition, encapsulation, and polymorphism.

Our team chose **SDG 6: Clean Water and Sanitation**, scoped specifically to the water availability and management side of the goal.

## What the App Does

The app is a Windows Forms simulation of a community's water supply. It models:

- A shared **Dam** that feeds multiple households through individual **Taps**
- Independent **Boreholes** that any household can draw from as a backup source
- **Households**, each with their own weekly water usage limit
- A **day/week cycle** that advances the simulation, refilling and resetting sources realistically over time

The goal is to show how a community might manage a limited, shared water resource fairly and sustainably — giving visibility into availability, enforcing fair usage limits, and modeling the fact that different water sources behave in genuinely different ways.

## The Problem It Addresses

Communities relying on shared or limited water sources often face:
- No visibility into how much water is actually available at any given time
- Unfair distribution, where some households can draw far more than their share
- Water sources treated identically in basic tracking tools, even though a dam, a borehole, and a tap behave very differently in real life

This system addresses that by giving each source its own rules for availability and recovery, and by enforcing a fair usage limit per household.

## How It Works

### 1. Initialise the System
On startup, the user enters the number of households, number of boreholes, the maximum weekly tap usage per household, and the dam's maximum capacity, then clicks **Initialise**. This creates the Dam, creates every Household (each linked to its own Tap, which in turn references the shared Dam), and creates every Borehole (each with its own refill rate).

### 2. Draw Water
- **From a tap:** the user selects a household and an amount. The household's tap checks its own remaining weekly allowance, then checks whether the shared Dam has enough water available (and is above its safety minimum). If both checks pass, the amount is deducted from the Dam and counted against that household's weekly usage.
- **From a borehole:** the user selects a household, a borehole, and an amount. The borehole checks its own remaining draw capacity for the day. Boreholes are communal — any household can draw from any borehole.

### 3. Advance the Day
Clicking **New Day** moves the simulation forward:
- **Every day:** each borehole refills back to its full draw capacity
- **Every 7th day (end of the week):** the week resets — every household's tap usage limit resets, and the Dam refills

### 4. View Status
The current status of the Dam and every Borehole (availability, amount remaining) is displayed and refreshed after every action, along with the current day. Household profiles can be viewed individually to check a specific household's usage.

## How This Addresses SDG 6

The system makes water availability visible across every source, enforces fair distribution through per-household weekly limits, and models realistic, source-specific behaviour rather than treating every water source as identical — directly supporting SDG 6's call for ensuring availability and sustainable management of water for all.