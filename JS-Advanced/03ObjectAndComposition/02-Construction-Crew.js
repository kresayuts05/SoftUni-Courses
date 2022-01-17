function solve(worker){
    if(worker.dizziness === true){
        worker.levelOfHydrated += 0.1 * worker.experience * worker.weight;
    }

  return worker;
}

solve({ weight: 120,
    experience: 20,
    levelOfHydrated: 200,
    dizziness: true }
  )