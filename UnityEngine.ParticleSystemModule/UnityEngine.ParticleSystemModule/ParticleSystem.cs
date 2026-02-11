using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine.ParticleSystemJobs;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public sealed class ParticleSystem : Component
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002D74 File Offset: 0x00000F74
		// Note: this type is marked as 'beforefieldinit'.
		static ParticleSystem()
		{
			Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine", "ParticleSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr);
			ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Vector3_Vector3_Single_Single_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663297);
			ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663298);
			ParticleSystem.NativeMethodInfoPtr_get_startDelay_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663299);
			ParticleSystem.NativeMethodInfoPtr_set_startDelay_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663300);
			ParticleSystem.NativeMethodInfoPtr_get_loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663301);
			ParticleSystem.NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663302);
			ParticleSystem.NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663303);
			ParticleSystem.NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663304);
			ParticleSystem.NativeMethodInfoPtr_get_duration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663305);
			ParticleSystem.NativeMethodInfoPtr_get_playbackSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663306);
			ParticleSystem.NativeMethodInfoPtr_set_playbackSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663307);
			ParticleSystem.NativeMethodInfoPtr_get_enableEmission_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663308);
			ParticleSystem.NativeMethodInfoPtr_set_enableEmission_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663309);
			ParticleSystem.NativeMethodInfoPtr_get_emissionRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663310);
			ParticleSystem.NativeMethodInfoPtr_set_emissionRate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663311);
			ParticleSystem.NativeMethodInfoPtr_get_startSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663312);
			ParticleSystem.NativeMethodInfoPtr_set_startSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663313);
			ParticleSystem.NativeMethodInfoPtr_get_startSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663314);
			ParticleSystem.NativeMethodInfoPtr_set_startSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663315);
			ParticleSystem.NativeMethodInfoPtr_get_startColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663316);
			ParticleSystem.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663317);
			ParticleSystem.NativeMethodInfoPtr_get_startRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663318);
			ParticleSystem.NativeMethodInfoPtr_set_startRotation_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663319);
			ParticleSystem.NativeMethodInfoPtr_get_startRotation3D_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663320);
			ParticleSystem.NativeMethodInfoPtr_set_startRotation3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663321);
			ParticleSystem.NativeMethodInfoPtr_get_startLifetime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663322);
			ParticleSystem.NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663323);
			ParticleSystem.NativeMethodInfoPtr_get_gravityModifier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663324);
			ParticleSystem.NativeMethodInfoPtr_set_gravityModifier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663325);
			ParticleSystem.NativeMethodInfoPtr_get_maxParticles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663326);
			ParticleSystem.NativeMethodInfoPtr_set_maxParticles_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663327);
			ParticleSystem.NativeMethodInfoPtr_get_simulationSpace_Public_get_ParticleSystemSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663328);
			ParticleSystem.NativeMethodInfoPtr_set_simulationSpace_Public_set_Void_ParticleSystemSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663329);
			ParticleSystem.NativeMethodInfoPtr_get_scalingMode_Public_get_ParticleSystemScalingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663330);
			ParticleSystem.NativeMethodInfoPtr_set_scalingMode_Public_set_Void_ParticleSystemScalingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663331);
			ParticleSystem.NativeMethodInfoPtr_get_automaticCullingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663332);
			ParticleSystem.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663333);
			ParticleSystem.NativeMethodInfoPtr_get_isEmitting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663334);
			ParticleSystem.NativeMethodInfoPtr_get_isStopped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663335);
			ParticleSystem.NativeMethodInfoPtr_get_isPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663336);
			ParticleSystem.NativeMethodInfoPtr_get_particleCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663337);
			ParticleSystem.NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663338);
			ParticleSystem.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663339);
			ParticleSystem.NativeMethodInfoPtr_get_totalTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663340);
			ParticleSystem.NativeMethodInfoPtr_get_randomSeed_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663341);
			ParticleSystem.NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663342);
			ParticleSystem.NativeMethodInfoPtr_get_useAutoRandomSeed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663343);
			ParticleSystem.NativeMethodInfoPtr_set_useAutoRandomSeed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663344);
			ParticleSystem.NativeMethodInfoPtr_get_proceduralSimulationSupported_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663345);
			ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentSize_Internal_Single_byref_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663346);
			ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentSize3D_Internal_Vector3_byref_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663347);
			ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentColor_Internal_Color32_byref_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663348);
			ParticleSystem.NativeMethodInfoPtr_GetParticleMeshIndex_Internal_Int32_byref_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663349);
			ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663350);
			ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663351);
			ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663352);
			ParticleSystem.NativeMethodInfoPtr_SetParticlesWithNativeArray_Private_Void_IntPtr_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663353);
			ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_NativeArray_1_Particle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663354);
			ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_NativeArray_1_Particle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663355);
			ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_NativeArray_1_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663356);
			ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663357);
			ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663358);
			ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663359);
			ParticleSystem.NativeMethodInfoPtr_GetParticlesWithNativeArray_Private_Int32_IntPtr_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663360);
			ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_NativeArray_1_Particle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663361);
			ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_NativeArray_1_Particle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663362);
			ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_NativeArray_1_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663363);
			ParticleSystem.NativeMethodInfoPtr_SetCustomParticleData_Public_Void_List_1_Vector4_ParticleSystemCustomData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663364);
			ParticleSystem.NativeMethodInfoPtr_GetCustomParticleData_Public_Int32_List_1_Vector4_ParticleSystemCustomData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663365);
			ParticleSystem.NativeMethodInfoPtr_GetPlaybackState_Public_PlaybackState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663366);
			ParticleSystem.NativeMethodInfoPtr_SetPlaybackState_Public_Void_PlaybackState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663367);
			ParticleSystem.NativeMethodInfoPtr_GetTrailDataInternal_Private_Void_byref_Trails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663368);
			ParticleSystem.NativeMethodInfoPtr_GetTrails_Public_Trails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663369);
			ParticleSystem.NativeMethodInfoPtr_GetTrails_Public_Int32_byref_Trails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663370);
			ParticleSystem.NativeMethodInfoPtr_SetTrails_Public_Void_Trails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663371);
			ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663372);
			ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663373);
			ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663374);
			ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663375);
			ParticleSystem.NativeMethodInfoPtr_Play_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663376);
			ParticleSystem.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663377);
			ParticleSystem.NativeMethodInfoPtr_Pause_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663378);
			ParticleSystem.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663379);
			ParticleSystem.NativeMethodInfoPtr_Stop_Public_Void_Boolean_ParticleSystemStopBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663380);
			ParticleSystem.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663381);
			ParticleSystem.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663382);
			ParticleSystem.NativeMethodInfoPtr_Clear_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663383);
			ParticleSystem.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663384);
			ParticleSystem.NativeMethodInfoPtr_IsAlive_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663385);
			ParticleSystem.NativeMethodInfoPtr_IsAlive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663386);
			ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663387);
			ParticleSystem.NativeMethodInfoPtr_Emit_Internal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663388);
			ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_EmitParams_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663389);
			ParticleSystem.NativeMethodInfoPtr_EmitOld_Internal_Private_Void_byref_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663390);
			ParticleSystem.NativeMethodInfoPtr_TriggerSubEmitter_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663391);
			ParticleSystem.NativeMethodInfoPtr_TriggerSubEmitter_Public_Void_Int32_byref_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663392);
			ParticleSystem.NativeMethodInfoPtr_TriggerSubEmitterForParticle_Internal_Void_Int32_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663393);
			ParticleSystem.NativeMethodInfoPtr_TriggerSubEmitter_Public_Void_Int32_List_1_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663394);
			ParticleSystem.NativeMethodInfoPtr_ResetPreMappedBufferMemory_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663395);
			ParticleSystem.NativeMethodInfoPtr_SetMaximumPreMappedBufferCounts_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663396);
			ParticleSystem.NativeMethodInfoPtr_AllocateAxisOfRotationAttribute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663397);
			ParticleSystem.NativeMethodInfoPtr_AllocateMeshIndexAttribute_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663398);
			ParticleSystem.NativeMethodInfoPtr_AllocateCustomDataAttribute_Public_Void_ParticleSystemCustomData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663399);
			ParticleSystem.NativeMethodInfoPtr_get_has3DParticleRotations_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663400);
			ParticleSystem.NativeMethodInfoPtr_get_hasNonUniformParticleSizes_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663401);
			ParticleSystem.NativeMethodInfoPtr_GetManagedJobData_Internal_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663402);
			ParticleSystem.NativeMethodInfoPtr_GetManagedJobHandle_Internal_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663403);
			ParticleSystem.NativeMethodInfoPtr_SetManagedJobHandle_Internal_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663404);
			ParticleSystem.NativeMethodInfoPtr_ScheduleManagedJob_Internal_Static_JobHandle_byref_JobScheduleParameters_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663405);
			ParticleSystem.NativeMethodInfoPtr_CopyManagedJobData_Internal_Static_Void_ptr_Void_byref_NativeParticleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663406);
			ParticleSystem.NativeMethodInfoPtr_UserJobCanBeScheduled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663407);
			ParticleSystem.NativeMethodInfoPtr_get_main_Public_get_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663408);
			ParticleSystem.NativeMethodInfoPtr_get_emission_Public_get_EmissionModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663409);
			ParticleSystem.NativeMethodInfoPtr_get_shape_Public_get_ShapeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663410);
			ParticleSystem.NativeMethodInfoPtr_get_velocityOverLifetime_Public_get_VelocityOverLifetimeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663411);
			ParticleSystem.NativeMethodInfoPtr_get_limitVelocityOverLifetime_Public_get_LimitVelocityOverLifetimeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663412);
			ParticleSystem.NativeMethodInfoPtr_get_inheritVelocity_Public_get_InheritVelocityModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663413);
			ParticleSystem.NativeMethodInfoPtr_get_lifetimeByEmitterSpeed_Public_get_LifetimeByEmitterSpeedModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663414);
			ParticleSystem.NativeMethodInfoPtr_get_forceOverLifetime_Public_get_ForceOverLifetimeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663415);
			ParticleSystem.NativeMethodInfoPtr_get_colorOverLifetime_Public_get_ColorOverLifetimeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663416);
			ParticleSystem.NativeMethodInfoPtr_get_colorBySpeed_Public_get_ColorBySpeedModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663417);
			ParticleSystem.NativeMethodInfoPtr_get_sizeOverLifetime_Public_get_SizeOverLifetimeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663418);
			ParticleSystem.NativeMethodInfoPtr_get_sizeBySpeed_Public_get_SizeBySpeedModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663419);
			ParticleSystem.NativeMethodInfoPtr_get_rotationOverLifetime_Public_get_RotationOverLifetimeModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663420);
			ParticleSystem.NativeMethodInfoPtr_get_rotationBySpeed_Public_get_RotationBySpeedModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663421);
			ParticleSystem.NativeMethodInfoPtr_get_externalForces_Public_get_ExternalForcesModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663422);
			ParticleSystem.NativeMethodInfoPtr_get_noise_Public_get_NoiseModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663423);
			ParticleSystem.NativeMethodInfoPtr_get_collision_Public_get_CollisionModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663424);
			ParticleSystem.NativeMethodInfoPtr_get_trigger_Public_get_TriggerModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663425);
			ParticleSystem.NativeMethodInfoPtr_get_subEmitters_Public_get_SubEmittersModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663426);
			ParticleSystem.NativeMethodInfoPtr_get_textureSheetAnimation_Public_get_TextureSheetAnimationModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663427);
			ParticleSystem.NativeMethodInfoPtr_get_lights_Public_get_LightsModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663428);
			ParticleSystem.NativeMethodInfoPtr_get_trails_Public_get_TrailModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663429);
			ParticleSystem.NativeMethodInfoPtr_get_customData_Public_get_CustomDataModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663430);
			ParticleSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663431);
			ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentSize3D_Injected_Private_Void_byref_Particle_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663432);
			ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentColor_Injected_Private_Void_byref_Particle_byref_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663433);
			ParticleSystem.NativeMethodInfoPtr_GetPlaybackState_Injected_Private_Void_byref_PlaybackState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663434);
			ParticleSystem.NativeMethodInfoPtr_SetPlaybackState_Injected_Private_Void_byref_PlaybackState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663435);
			ParticleSystem.NativeMethodInfoPtr_SetTrails_Injected_Private_Void_byref_Trails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663436);
			ParticleSystem.NativeMethodInfoPtr_Emit_Injected_Private_Void_byref_EmitParams_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663437);
			ParticleSystem.NativeMethodInfoPtr_TriggerSubEmitterForParticle_Injected_Private_Void_Int32_byref_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663438);
			ParticleSystem.NativeMethodInfoPtr_GetManagedJobHandle_Injected_Private_Void_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663439);
			ParticleSystem.NativeMethodInfoPtr_SetManagedJobHandle_Injected_Private_Void_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663440);
			ParticleSystem.NativeMethodInfoPtr_ScheduleManagedJob_Injected_Private_Static_Void_byref_JobScheduleParameters_ptr_Void_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, 100663441);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000038F8 File Offset: 0x00001AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221154, XrefRangeEnd = 1221160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref velocity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Vector3_Vector3_Single_Single_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00003970 File Offset: 0x00001B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221160, XrefRangeEnd = 1221162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref particle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000039B0 File Offset: 0x00001BB0
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000039EC File Offset: 0x00001BEC
		public unsafe float startDelay
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221162, XrefRangeEnd = 1221165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_startDelay_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221165, XrefRangeEnd = 1221168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_startDelay_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00003A2C File Offset: 0x00001C2C
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00003A68 File Offset: 0x00001C68
		public unsafe bool loop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221168, XrefRangeEnd = 1221171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_loop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221171, XrefRangeEnd = 1221174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00003AA8 File Offset: 0x00001CA8
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00003AE4 File Offset: 0x00001CE4
		public unsafe bool playOnAwake
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221174, XrefRangeEnd = 1221177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221177, XrefRangeEnd = 1221180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00003B24 File Offset: 0x00001D24
		public unsafe float duration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221180, XrefRangeEnd = 1221183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_duration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00003B60 File Offset: 0x00001D60
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00003B9C File Offset: 0x00001D9C
		public unsafe float playbackSpeed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221183, XrefRangeEnd = 1221186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_playbackSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221186, XrefRangeEnd = 1221189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_playbackSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00003BDC File Offset: 0x00001DDC
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00003C18 File Offset: 0x00001E18
		public unsafe bool enableEmission
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221189, XrefRangeEnd = 1221192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_enableEmission_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221192, XrefRangeEnd = 1221195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_enableEmission_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00003C58 File Offset: 0x00001E58
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00003C94 File Offset: 0x00001E94
		public unsafe float emissionRate
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221195, XrefRangeEnd = 1221198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_emissionRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221198, XrefRangeEnd = 1221203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_emissionRate_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00003CD4 File Offset: 0x00001ED4
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00003D10 File Offset: 0x00001F10
		public unsafe float startSpeed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221203, XrefRangeEnd = 1221206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_startSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221206, XrefRangeEnd = 1221209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_startSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00003D50 File Offset: 0x00001F50
		// (set) Token: 0x06000014 RID: 20 RVA: 0x00003D8C File Offset: 0x00001F8C
		public unsafe float startSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221209, XrefRangeEnd = 1221212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_startSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221212, XrefRangeEnd = 1221215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_startSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00003DCC File Offset: 0x00001FCC
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00003E08 File Offset: 0x00002008
		public unsafe Color startColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221215, XrefRangeEnd = 1221218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_startColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221218, XrefRangeEnd = 1221223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00003E48 File Offset: 0x00002048
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00003E84 File Offset: 0x00002084
		public unsafe float startRotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221223, XrefRangeEnd = 1221226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_startRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221226, XrefRangeEnd = 1221229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_startRotation_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00003EC4 File Offset: 0x000020C4
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00003F00 File Offset: 0x00002100
		public unsafe Vector3 startRotation3D
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221229, XrefRangeEnd = 1221238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_startRotation3D_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221238, XrefRangeEnd = 1221245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_startRotation3D_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00003F40 File Offset: 0x00002140
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00003F7C File Offset: 0x0000217C
		public unsafe float startLifetime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221245, XrefRangeEnd = 1221248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_startLifetime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221248, XrefRangeEnd = 1221251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00003FBC File Offset: 0x000021BC
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00003FF8 File Offset: 0x000021F8
		public unsafe float gravityModifier
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221251, XrefRangeEnd = 1221254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_gravityModifier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221254, XrefRangeEnd = 1221257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_gravityModifier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00004038 File Offset: 0x00002238
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00004074 File Offset: 0x00002274
		public unsafe int maxParticles
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221257, XrefRangeEnd = 1221260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_maxParticles_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221260, XrefRangeEnd = 1221263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_maxParticles_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000040B4 File Offset: 0x000022B4
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000040F0 File Offset: 0x000022F0
		public unsafe ParticleSystemSimulationSpace simulationSpace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221263, XrefRangeEnd = 1221266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_simulationSpace_Public_get_ParticleSystemSimulationSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221266, XrefRangeEnd = 1221269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_simulationSpace_Public_set_Void_ParticleSystemSimulationSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00004130 File Offset: 0x00002330
		// (set) Token: 0x06000024 RID: 36 RVA: 0x0000416C File Offset: 0x0000236C
		public unsafe ParticleSystemScalingMode scalingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221269, XrefRangeEnd = 1221272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_scalingMode_Public_get_ParticleSystemScalingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221272, XrefRangeEnd = 1221275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_scalingMode_Public_set_Void_ParticleSystemScalingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000041AC File Offset: 0x000023AC
		public unsafe bool automaticCullingEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221275, XrefRangeEnd = 1221277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_automaticCullingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000041E8 File Offset: 0x000023E8
		public unsafe bool isPlaying
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221277, XrefRangeEnd = 1221279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00004224 File Offset: 0x00002424
		public unsafe bool isEmitting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221279, XrefRangeEnd = 1221281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_isEmitting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00004260 File Offset: 0x00002460
		public unsafe bool isStopped
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221281, XrefRangeEnd = 1221283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_isStopped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000029 RID: 41 RVA: 0x0000429C File Offset: 0x0000249C
		public unsafe bool isPaused
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221283, XrefRangeEnd = 1221285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_isPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000042D8 File Offset: 0x000024D8
		public unsafe int particleCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221285, XrefRangeEnd = 1221287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_particleCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00004314 File Offset: 0x00002514
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00004350 File Offset: 0x00002550
		public unsafe float time
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221287, XrefRangeEnd = 1221289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221289, XrefRangeEnd = 1221291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00004390 File Offset: 0x00002590
		public unsafe float totalTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221291, XrefRangeEnd = 1221293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_totalTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000043CC File Offset: 0x000025CC
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00004408 File Offset: 0x00002608
		public unsafe uint randomSeed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221293, XrefRangeEnd = 1221295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_randomSeed_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221295, XrefRangeEnd = 1221297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00004448 File Offset: 0x00002648
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00004484 File Offset: 0x00002684
		public unsafe bool useAutoRandomSeed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221297, XrefRangeEnd = 1221299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_useAutoRandomSeed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221299, XrefRangeEnd = 1221301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_set_useAutoRandomSeed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000044C4 File Offset: 0x000026C4
		public unsafe bool proceduralSimulationSupported
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_proceduralSimulationSupported_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004500 File Offset: 0x00002700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221301, XrefRangeEnd = 1221303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetParticleCurrentSize(ref ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &particle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentSize_Internal_Single_byref_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000454C File Offset: 0x0000274C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221303, XrefRangeEnd = 1221305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetParticleCurrentSize3D(ref ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &particle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentSize3D_Internal_Vector3_byref_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004598 File Offset: 0x00002798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221305, XrefRangeEnd = 1221307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color32 GetParticleCurrentColor(ref ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &particle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentColor_Internal_Color32_byref_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000045E4 File Offset: 0x000027E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221307, XrefRangeEnd = 1221309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticleMeshIndex(ref ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &particle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticleMeshIndex_Internal_Int32_byref_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004630 File Offset: 0x00002830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221309, XrefRangeEnd = 1221311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles, int size, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000046A0 File Offset: 0x000028A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221311, XrefRangeEnd = 1221313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004700 File Offset: 0x00002900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221313, XrefRangeEnd = 1221315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004754 File Offset: 0x00002954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221315, XrefRangeEnd = 1221317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref particles;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref particlesLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetParticlesWithNativeArray_Private_Void_IntPtr_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000047BC File Offset: 0x000029BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221317, XrefRangeEnd = 1221323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_NativeArray_1_Particle_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new NativeArray<ParticleSystem.Particle>(intPtr4));
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000482C File Offset: 0x00002A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221323, XrefRangeEnd = 1221329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_NativeArray_1_Particle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new NativeArray<ParticleSystem.Particle>(intPtr4));
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000488C File Offset: 0x00002A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221329, XrefRangeEnd = 1221335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetParticles_Public_Void_NativeArray_1_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*particles = ((intPtr4 == 0) ? null : new NativeArray<ParticleSystem.Particle>(intPtr4));
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000048E0 File Offset: 0x00002AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221335, XrefRangeEnd = 1221337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles, int size, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000495C File Offset: 0x00002B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221337, XrefRangeEnd = 1221339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000049C8 File Offset: 0x00002BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221339, XrefRangeEnd = 1221341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticles([Out] Il2CppStructArray<ParticleSystem.Particle> particles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*particles = ((intPtr4 == 0) ? null : new Il2CppStructArray<ParticleSystem.Particle>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004A28 File Offset: 0x00002C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221341, XrefRangeEnd = 1221343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref particles;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref particlesLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticlesWithNativeArray_Private_Int32_IntPtr_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004A9C File Offset: 0x00002C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221343, XrefRangeEnd = 1221349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_NativeArray_1_Particle_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new NativeArray<ParticleSystem.Particle>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004B18 File Offset: 0x00002D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221349, XrefRangeEnd = 1221355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_NativeArray_1_Particle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*particles = ((intPtr4 == 0) ? null : new NativeArray<ParticleSystem.Particle>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004B84 File Offset: 0x00002D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221355, XrefRangeEnd = 1221361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticles_Public_Int32_NativeArray_1_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*particles = ((intPtr4 == 0) ? null : new NativeArray<ParticleSystem.Particle>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004BE4 File Offset: 0x00002DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221361, XrefRangeEnd = 1221363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref streamIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetCustomParticleData_Public_Void_List_1_Vector4_ParticleSystemCustomData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004C34 File Offset: 0x00002E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221363, XrefRangeEnd = 1221365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(customData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref streamIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetCustomParticleData_Public_Int32_List_1_Vector4_ParticleSystemCustomData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004C90 File Offset: 0x00002E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221365, XrefRangeEnd = 1221368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleSystem.PlaybackState GetPlaybackState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetPlaybackState_Public_PlaybackState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004CCC File Offset: 0x00002ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221368, XrefRangeEnd = 1221370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlaybackState(ParticleSystem.PlaybackState playbackState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playbackState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetPlaybackState_Public_Void_PlaybackState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004D0C File Offset: 0x00002F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221370, XrefRangeEnd = 1221372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTrailDataInternal(ref ParticleSystem.Trails trailData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(trailData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetTrailDataInternal_Private_Void_byref_Trails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004D50 File Offset: 0x00002F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221372, XrefRangeEnd = 1221375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleSystem.Trails GetTrails()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetTrails_Public_Trails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ParticleSystem.Trails(intPtr);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004D88 File Offset: 0x00002F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221375, XrefRangeEnd = 1221379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTrails(ref ParticleSystem.Trails trailData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(trailData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetTrails_Public_Int32_byref_Trails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004DD8 File Offset: 0x00002FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221379, XrefRangeEnd = 1221381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrails(ParticleSystem.Trails trailData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(trailData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetTrails_Public_Void_Trails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004E20 File Offset: 0x00003020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221381, XrefRangeEnd = 1221383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withChildren;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fixedTimeStep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004E88 File Offset: 0x00003088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221383, XrefRangeEnd = 1221385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Simulate(float t, bool withChildren, bool restart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withChildren;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restart;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004EE4 File Offset: 0x000030E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221385, XrefRangeEnd = 1221387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Simulate(float t, bool withChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref withChildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004F30 File Offset: 0x00003130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221387, XrefRangeEnd = 1221389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Simulate(float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Simulate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004F70 File Offset: 0x00003170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221389, XrefRangeEnd = 1221391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(bool withChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withChildren;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Play_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004FB0 File Offset: 0x000031B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1221393, RefRangeEnd = 1221395, XrefRangeStart = 1221391, XrefRangeEnd = 1221393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004FE4 File Offset: 0x000031E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1221397, RefRangeEnd = 1221398, XrefRangeStart = 1221395, XrefRangeEnd = 1221397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause(bool withChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withChildren;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Pause_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005024 File Offset: 0x00003224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1221400, RefRangeEnd = 1221401, XrefRangeStart = 1221398, XrefRangeEnd = 1221400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00005058 File Offset: 0x00003258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221401, XrefRangeEnd = 1221403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withChildren;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stopBehavior;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Stop_Public_Void_Boolean_ParticleSystemStopBehavior_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000050A4 File Offset: 0x000032A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221403, XrefRangeEnd = 1221405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(bool withChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withChildren;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Stop_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000050E4 File Offset: 0x000032E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221405, XrefRangeEnd = 1221407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00005118 File Offset: 0x00003318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221407, XrefRangeEnd = 1221409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(bool withChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withChildren;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Clear_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005158 File Offset: 0x00003358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221409, XrefRangeEnd = 1221411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000518C File Offset: 0x0000338C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221411, XrefRangeEnd = 1221413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAlive(bool withChildren)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withChildren;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_IsAlive_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000051D8 File Offset: 0x000033D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221413, XrefRangeEnd = 1221415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAlive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_IsAlive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00005214 File Offset: 0x00003414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221415, XrefRangeEnd = 1221417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005254 File Offset: 0x00003454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit_Internal(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Internal_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00005294 File Offset: 0x00003494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221417, XrefRangeEnd = 1221419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(ParticleSystem.EmitParams emitParams, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref emitParams;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Public_Void_EmitParams_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000052E0 File Offset: 0x000034E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221419, XrefRangeEnd = 1221421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitOld_Internal(ref ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &particle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_EmitOld_Internal_Private_Void_byref_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00005320 File Offset: 0x00003520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221421, XrefRangeEnd = 1221423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerSubEmitter(int subEmitterIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subEmitterIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_TriggerSubEmitter_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00005360 File Offset: 0x00003560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221423, XrefRangeEnd = 1221425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerSubEmitter(int subEmitterIndex, ref ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subEmitterIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &particle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_TriggerSubEmitter_Public_Void_Int32_byref_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000053AC File Offset: 0x000035AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221425, XrefRangeEnd = 1221427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerSubEmitterForParticle(int subEmitterIndex, ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subEmitterIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref particle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_TriggerSubEmitterForParticle_Internal_Void_Int32_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000053F8 File Offset: 0x000035F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221427, XrefRangeEnd = 1221429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerSubEmitter(int subEmitterIndex, List<ParticleSystem.Particle> particles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subEmitterIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_TriggerSubEmitter_Public_Void_Int32_List_1_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005448 File Offset: 0x00003648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221429, XrefRangeEnd = 1221431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResetPreMappedBufferMemory()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_ResetPreMappedBufferMemory_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005470 File Offset: 0x00003670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221431, XrefRangeEnd = 1221433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vertexBuffersCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexBuffersCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetMaximumPreMappedBufferCounts_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000054B0 File Offset: 0x000036B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221433, XrefRangeEnd = 1221435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllocateAxisOfRotationAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_AllocateAxisOfRotationAttribute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000054E4 File Offset: 0x000036E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221435, XrefRangeEnd = 1221437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllocateMeshIndexAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_AllocateMeshIndexAttribute_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00005518 File Offset: 0x00003718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221437, XrefRangeEnd = 1221439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllocateCustomDataAttribute(ParticleSystemCustomData stream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stream;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_AllocateCustomDataAttribute_Public_Void_ParticleSystemCustomData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00005558 File Offset: 0x00003758
		public unsafe bool has3DParticleRotations
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221439, XrefRangeEnd = 1221441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_has3DParticleRotations_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00005594 File Offset: 0x00003794
		public unsafe bool hasNonUniformParticleSizes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221441, XrefRangeEnd = 1221443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_hasNonUniformParticleSizes_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000055D0 File Offset: 0x000037D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221443, XrefRangeEnd = 1221445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void* GetManagedJobData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetManagedJobData_Internal_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005604 File Offset: 0x00003804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221445, XrefRangeEnd = 1221447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JobHandle GetManagedJobHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetManagedJobHandle_Internal_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005640 File Offset: 0x00003840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221447, XrefRangeEnd = 1221449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetManagedJobHandle(JobHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetManagedJobHandle_Internal_Void_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005680 File Offset: 0x00003880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221449, XrefRangeEnd = 1221451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = additionalData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_ScheduleManagedJob_Internal_Static_JobHandle_byref_JobScheduleParameters_ptr_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000056CC File Offset: 0x000038CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221451, XrefRangeEnd = 1221453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = systemPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &particleData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_CopyManagedJobData_Internal_Static_Void_ptr_Void_byref_NativeParticleData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000570C File Offset: 0x0000390C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221453, XrefRangeEnd = 1221455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UserJobCanBeScheduled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_UserJobCanBeScheduled_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000573C File Offset: 0x0000393C
		public unsafe ParticleSystem.MainModule main
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_main_Public_get_MainModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.MainModule(intPtr);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00005774 File Offset: 0x00003974
		public unsafe ParticleSystem.EmissionModule emission
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_emission_Public_get_EmissionModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.EmissionModule(intPtr);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000057AC File Offset: 0x000039AC
		public unsafe ParticleSystem.ShapeModule shape
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_shape_Public_get_ShapeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.ShapeModule(intPtr);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000057E4 File Offset: 0x000039E4
		public unsafe ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_velocityOverLifetime_Public_get_VelocityOverLifetimeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.VelocityOverLifetimeModule(intPtr);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000581C File Offset: 0x00003A1C
		public unsafe ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetime
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_limitVelocityOverLifetime_Public_get_LimitVelocityOverLifetimeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.LimitVelocityOverLifetimeModule(intPtr);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00005854 File Offset: 0x00003A54
		public unsafe ParticleSystem.InheritVelocityModule inheritVelocity
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_inheritVelocity_Public_get_InheritVelocityModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.InheritVelocityModule(intPtr);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000588C File Offset: 0x00003A8C
		public unsafe ParticleSystem.LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_lifetimeByEmitterSpeed_Public_get_LifetimeByEmitterSpeedModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.LifetimeByEmitterSpeedModule(intPtr);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000058C4 File Offset: 0x00003AC4
		public unsafe ParticleSystem.ForceOverLifetimeModule forceOverLifetime
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_forceOverLifetime_Public_get_ForceOverLifetimeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.ForceOverLifetimeModule(intPtr);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000058FC File Offset: 0x00003AFC
		public unsafe ParticleSystem.ColorOverLifetimeModule colorOverLifetime
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_colorOverLifetime_Public_get_ColorOverLifetimeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.ColorOverLifetimeModule(intPtr);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00005934 File Offset: 0x00003B34
		public unsafe ParticleSystem.ColorBySpeedModule colorBySpeed
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_colorBySpeed_Public_get_ColorBySpeedModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.ColorBySpeedModule(intPtr);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000596C File Offset: 0x00003B6C
		public unsafe ParticleSystem.SizeOverLifetimeModule sizeOverLifetime
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_sizeOverLifetime_Public_get_SizeOverLifetimeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.SizeOverLifetimeModule(intPtr);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000059A4 File Offset: 0x00003BA4
		public unsafe ParticleSystem.SizeBySpeedModule sizeBySpeed
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_sizeBySpeed_Public_get_SizeBySpeedModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.SizeBySpeedModule(intPtr);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000059DC File Offset: 0x00003BDC
		public unsafe ParticleSystem.RotationOverLifetimeModule rotationOverLifetime
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_rotationOverLifetime_Public_get_RotationOverLifetimeModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.RotationOverLifetimeModule(intPtr);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00005A14 File Offset: 0x00003C14
		public unsafe ParticleSystem.RotationBySpeedModule rotationBySpeed
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_rotationBySpeed_Public_get_RotationBySpeedModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.RotationBySpeedModule(intPtr);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00005A4C File Offset: 0x00003C4C
		public unsafe ParticleSystem.ExternalForcesModule externalForces
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_externalForces_Public_get_ExternalForcesModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.ExternalForcesModule(intPtr);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00005A84 File Offset: 0x00003C84
		public unsafe ParticleSystem.NoiseModule noise
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_noise_Public_get_NoiseModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.NoiseModule(intPtr);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00005ABC File Offset: 0x00003CBC
		public unsafe ParticleSystem.CollisionModule collision
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_collision_Public_get_CollisionModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.CollisionModule(intPtr);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00005AF4 File Offset: 0x00003CF4
		public unsafe ParticleSystem.TriggerModule trigger
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_trigger_Public_get_TriggerModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.TriggerModule(intPtr);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00005B2C File Offset: 0x00003D2C
		public unsafe ParticleSystem.SubEmittersModule subEmitters
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_subEmitters_Public_get_SubEmittersModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.SubEmittersModule(intPtr);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00005B64 File Offset: 0x00003D64
		public unsafe ParticleSystem.TextureSheetAnimationModule textureSheetAnimation
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_textureSheetAnimation_Public_get_TextureSheetAnimationModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.TextureSheetAnimationModule(intPtr);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00005B9C File Offset: 0x00003D9C
		public unsafe ParticleSystem.LightsModule lights
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_lights_Public_get_LightsModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.LightsModule(intPtr);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00005BD4 File Offset: 0x00003DD4
		public unsafe ParticleSystem.TrailModule trails
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_trails_Public_get_TrailModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.TrailModule(intPtr);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00005C0C File Offset: 0x00003E0C
		public unsafe ParticleSystem.CustomDataModule customData
		{
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 571951, RefRangeEnd = 572001, XrefRangeStart = 571951, XrefRangeEnd = 572001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_get_customData_Public_get_CustomDataModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ParticleSystem.CustomDataModule(intPtr);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00005C44 File Offset: 0x00003E44
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00005C80 File Offset: 0x00003E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221455, XrefRangeEnd = 1221457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetParticleCurrentSize3D_Injected(ref ParticleSystem.Particle particle, out Vector3 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &particle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentSize3D_Injected_Private_Void_byref_Particle_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005CCC File Offset: 0x00003ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221457, XrefRangeEnd = 1221459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetParticleCurrentColor_Injected(ref ParticleSystem.Particle particle, out Color32 ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &particle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetParticleCurrentColor_Injected_Private_Void_byref_Particle_byref_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00005D18 File Offset: 0x00003F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221459, XrefRangeEnd = 1221461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetPlaybackState_Injected(out ParticleSystem.PlaybackState ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetPlaybackState_Injected_Private_Void_byref_PlaybackState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005D58 File Offset: 0x00003F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221461, XrefRangeEnd = 1221463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlaybackState_Injected(ref ParticleSystem.PlaybackState playbackState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &playbackState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetPlaybackState_Injected_Private_Void_byref_PlaybackState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005D98 File Offset: 0x00003F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221463, XrefRangeEnd = 1221465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrails_Injected(ref ParticleSystem.Trails trailData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(trailData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetTrails_Injected_Private_Void_byref_Trails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00005DDC File Offset: 0x00003FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221465, XrefRangeEnd = 1221467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &emitParams;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_Emit_Injected_Private_Void_byref_EmitParams_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00005E28 File Offset: 0x00004028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221467, XrefRangeEnd = 1221469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref ParticleSystem.Particle particle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref subEmitterIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &particle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_TriggerSubEmitterForParticle_Injected_Private_Void_Int32_byref_Particle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005E74 File Offset: 0x00004074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221469, XrefRangeEnd = 1221471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetManagedJobHandle_Injected(out JobHandle ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_GetManagedJobHandle_Injected_Private_Void_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00005EB4 File Offset: 0x000040B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221471, XrefRangeEnd = 1221473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetManagedJobHandle_Injected(ref JobHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_SetManagedJobHandle_Injected_Private_Void_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00005EF4 File Offset: 0x000040F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221473, XrefRangeEnd = 1221475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &parameters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = additionalData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NativeMethodInfoPtr_ScheduleManagedJob_Injected_Private_Static_Void_byref_JobScheduleParameters_ptr_Void_byref_JobHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		public ParticleSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_Vector3_Vector3_Single_Single_Color32_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_Particle_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_get_startDelay_Public_get_Single_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_set_startDelay_Public_set_Void_Single_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_loop_Public_get_Boolean_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_get_Single_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_playbackSpeed_Public_get_Single_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_set_playbackSpeed_Public_set_Void_Single_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_enableEmission_Public_get_Boolean_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_set_enableEmission_Public_set_Void_Boolean_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_get_emissionRate_Public_get_Single_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_set_emissionRate_Public_set_Void_Single_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_startSpeed_Public_get_Single_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_set_startSpeed_Public_set_Void_Single_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_get_startSize_Public_get_Single_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_set_startSize_Public_set_Void_Single_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Public_get_Color_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_startRotation_Public_get_Single_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_set_startRotation_Public_set_Void_Single_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_get_startRotation3D_Public_get_Vector3_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_set_startRotation3D_Public_set_Void_Vector3_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_startLifetime_Public_get_Single_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_gravityModifier_Public_get_Single_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_set_gravityModifier_Public_set_Void_Single_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_maxParticles_Public_get_Int32_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_set_maxParticles_Public_set_Void_Int32_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_simulationSpace_Public_get_ParticleSystemSimulationSpace_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_set_simulationSpace_Public_set_Void_ParticleSystemSimulationSpace_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_scalingMode_Public_get_ParticleSystemScalingMode_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_set_scalingMode_Public_set_Void_ParticleSystemScalingMode_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_automaticCullingEnabled_Public_get_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_isEmitting_Public_get_Boolean_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_isStopped_Public_get_Boolean_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_isPaused_Public_get_Boolean_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_particleCount_Public_get_Int32_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Single_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_get_totalTime_Public_get_Single_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_get_randomSeed_Public_get_UInt32_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_get_useAutoRandomSeed_Public_get_Boolean_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_set_useAutoRandomSeed_Public_set_Void_Boolean_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_get_proceduralSimulationSupported_Public_get_Boolean_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_GetParticleCurrentSize_Internal_Single_byref_Particle_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_GetParticleCurrentSize3D_Internal_Vector3_byref_Particle_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_GetParticleCurrentColor_Internal_Color32_byref_Particle_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_GetParticleMeshIndex_Internal_Int32_byref_Particle_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_Int32_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_Int32_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_SetParticles_Public_Void_Il2CppStructArray_1_Particle_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_SetParticlesWithNativeArray_Private_Void_IntPtr_Int32_Int32_Int32_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_SetParticles_Public_Void_NativeArray_1_Particle_Int32_Int32_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_SetParticles_Public_Void_NativeArray_1_Particle_Int32_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_SetParticles_Public_Void_NativeArray_1_Particle_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_Int32_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_Int32_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_GetParticles_Public_Int32_Il2CppStructArray_1_Particle_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_GetParticlesWithNativeArray_Private_Int32_IntPtr_Int32_Int32_Int32_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_GetParticles_Public_Int32_NativeArray_1_Particle_Int32_Int32_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_GetParticles_Public_Int32_NativeArray_1_Particle_Int32_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_GetParticles_Public_Int32_NativeArray_1_Particle_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_SetCustomParticleData_Public_Void_List_1_Vector4_ParticleSystemCustomData_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomParticleData_Public_Int32_List_1_Vector4_ParticleSystemCustomData_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaybackState_Public_PlaybackState_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_SetPlaybackState_Public_Void_PlaybackState_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_GetTrailDataInternal_Private_Void_byref_Trails_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_GetTrails_Public_Trails_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_GetTrails_Public_Int32_byref_Trails_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_SetTrails_Public_Void_Trails_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_Boolean_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_Boolean_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Public_Void_Single_Boolean_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Public_Void_Single_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_Boolean_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_Boolean_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_Boolean_ParticleSystemStopBehavior_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_Boolean_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_Boolean_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_IsAlive_Public_Boolean_Boolean_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_IsAlive_Public_Boolean_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_Int32_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Internal_Private_Void_Int32_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_EmitParams_Int32_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_EmitOld_Internal_Private_Void_byref_Particle_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_TriggerSubEmitter_Public_Void_Int32_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_TriggerSubEmitter_Public_Void_Int32_byref_Particle_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_TriggerSubEmitterForParticle_Internal_Void_Int32_Particle_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_TriggerSubEmitter_Public_Void_Int32_List_1_Particle_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_ResetPreMappedBufferMemory_Public_Static_Void_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_SetMaximumPreMappedBufferCounts_Public_Static_Void_Int32_Int32_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_AllocateAxisOfRotationAttribute_Public_Void_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_AllocateMeshIndexAttribute_Public_Void_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_AllocateCustomDataAttribute_Public_Void_ParticleSystemCustomData_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_get_has3DParticleRotations_Public_get_Boolean_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_get_hasNonUniformParticleSizes_Public_get_Boolean_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_GetManagedJobData_Internal_ptr_Void_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_GetManagedJobHandle_Internal_JobHandle_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_SetManagedJobHandle_Internal_Void_JobHandle_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleManagedJob_Internal_Static_JobHandle_byref_JobScheduleParameters_ptr_Void_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_CopyManagedJobData_Internal_Static_Void_ptr_Void_byref_NativeParticleData_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_UserJobCanBeScheduled_Internal_Static_Boolean_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_get_main_Public_get_MainModule_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_emission_Public_get_EmissionModule_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_get_shape_Public_get_ShapeModule_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_velocityOverLifetime_Public_get_VelocityOverLifetimeModule_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_get_limitVelocityOverLifetime_Public_get_LimitVelocityOverLifetimeModule_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_inheritVelocity_Public_get_InheritVelocityModule_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_get_lifetimeByEmitterSpeed_Public_get_LifetimeByEmitterSpeedModule_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_get_forceOverLifetime_Public_get_ForceOverLifetimeModule_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_get_colorOverLifetime_Public_get_ColorOverLifetimeModule_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_get_colorBySpeed_Public_get_ColorBySpeedModule_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_get_sizeOverLifetime_Public_get_SizeOverLifetimeModule_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_get_sizeBySpeed_Public_get_SizeBySpeedModule_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationOverLifetime_Public_get_RotationOverLifetimeModule_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_get_rotationBySpeed_Public_get_RotationBySpeedModule_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_externalForces_Public_get_ExternalForcesModule_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_get_noise_Public_get_NoiseModule_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_get_collision_Public_get_CollisionModule_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_get_trigger_Public_get_TriggerModule_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_subEmitters_Public_get_SubEmittersModule_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_get_textureSheetAnimation_Public_get_TextureSheetAnimationModule_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_get_lights_Public_get_LightsModule_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_get_trails_Public_get_TrailModule_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_get_customData_Public_get_CustomDataModule_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_GetParticleCurrentSize3D_Injected_Private_Void_byref_Particle_byref_Vector3_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_GetParticleCurrentColor_Injected_Private_Void_byref_Particle_byref_Color32_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaybackState_Injected_Private_Void_byref_PlaybackState_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_SetPlaybackState_Injected_Private_Void_byref_PlaybackState_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_SetTrails_Injected_Private_Void_byref_Trails_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Injected_Private_Void_byref_EmitParams_Int32_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_TriggerSubEmitterForParticle_Injected_Private_Void_Int32_byref_Particle_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_GetManagedJobHandle_Injected_Private_Void_byref_JobHandle_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_SetManagedJobHandle_Injected_Private_Void_byref_JobHandle_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleManagedJob_Injected_Private_Static_Void_byref_JobScheduleParameters_ptr_Void_byref_JobHandle_0;

		// Token: 0x0200003E RID: 62
		public sealed class MainModule : ValueType
		{
			// Token: 0x0600013F RID: 319 RVA: 0x000089BC File Offset: 0x00006BBC
			// Note: this type is marked as 'beforefieldinit'.
			static MainModule()
			{
				Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "MainModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr);
				ParticleSystem.MainModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.MainModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663442);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_duration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663443);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663444);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663445);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startDelayMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663446);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startDelayMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663447);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startLifetimeMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663448);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startLifetimeMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663449);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startSpeedMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663450);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSpeedMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663451);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startSizeMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663452);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSizeMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663453);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663454);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663455);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationXMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663456);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationXMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663457);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationYMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663458);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationYMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663459);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationZMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663460);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationZMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663461);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startColor_Public_get_MinMaxGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663462);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startColor_Public_set_Void_MinMaxGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663463);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_gravityModifierMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663464);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_gravityModifierMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663465);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_simulationSpace_Public_get_ParticleSystemSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663466);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_simulationSpace_Public_set_Void_ParticleSystemSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663467);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_simulationSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663468);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_simulationSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663469);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_scalingMode_Public_get_ParticleSystemScalingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663470);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_scalingMode_Public_set_Void_ParticleSystemScalingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663471);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663472);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663473);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_maxParticles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663474);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_maxParticles_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663475);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_stopAction_Public_set_Void_ParticleSystemStopAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663476);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_duration_Injected_Private_Static_Single_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663477);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_loop_Injected_Private_Static_Boolean_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663478);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_loop_Injected_Private_Static_Void_byref_MainModule_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663479);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startDelayMultiplier_Injected_Private_Static_Single_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663480);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startDelayMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663481);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startLifetimeMultiplier_Injected_Private_Static_Single_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663482);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startLifetimeMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663483);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startSpeedMultiplier_Injected_Private_Static_Single_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663484);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSpeedMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663485);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startSizeMultiplier_Injected_Private_Static_Single_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663486);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSizeMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663487);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationMultiplier_Injected_Private_Static_Single_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663488);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663489);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationXMultiplier_Injected_Private_Static_Single_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663490);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationXMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663491);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationYMultiplier_Injected_Private_Static_Single_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663492);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationYMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663493);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationZMultiplier_Injected_Private_Static_Single_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663494);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationZMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663495);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_startColor_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663496);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_startColor_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxGradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663497);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_gravityModifierMultiplier_Injected_Private_Static_Single_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663498);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_gravityModifierMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663499);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_simulationSpace_Injected_Private_Static_ParticleSystemSimulationSpace_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663500);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_simulationSpace_Injected_Private_Static_Void_byref_MainModule_ParticleSystemSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663501);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_simulationSpeed_Injected_Private_Static_Single_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663502);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_simulationSpeed_Injected_Private_Static_Void_byref_MainModule_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663503);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_scalingMode_Injected_Private_Static_ParticleSystemScalingMode_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663504);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_scalingMode_Injected_Private_Static_Void_byref_MainModule_ParticleSystemScalingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663505);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_playOnAwake_Injected_Private_Static_Boolean_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663506);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_playOnAwake_Injected_Private_Static_Void_byref_MainModule_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663507);
				ParticleSystem.MainModule.NativeMethodInfoPtr_get_maxParticles_Injected_Private_Static_Int32_byref_MainModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663508);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_maxParticles_Injected_Private_Static_Void_byref_MainModule_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663509);
				ParticleSystem.MainModule.NativeMethodInfoPtr_set_stopAction_Injected_Private_Static_Void_byref_MainModule_ParticleSystemStopAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr, 100663510);
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00008F60 File Offset: 0x00007160
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MainModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000141 RID: 321 RVA: 0x00008FB0 File Offset: 0x000071B0
			public unsafe float duration
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221008, XrefRangeEnd = 1221010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_duration_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x06000142 RID: 322 RVA: 0x00008FF4 File Offset: 0x000071F4
			// (set) Token: 0x06000143 RID: 323 RVA: 0x00009038 File Offset: 0x00007238
			public unsafe bool loop
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221010, XrefRangeEnd = 1221012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_loop_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1221014, RefRangeEnd = 1221015, XrefRangeStart = 1221012, XrefRangeEnd = 1221014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000144 RID: 324 RVA: 0x0000907C File Offset: 0x0000727C
			// (set) Token: 0x06000145 RID: 325 RVA: 0x000090C0 File Offset: 0x000072C0
			public unsafe float startDelayMultiplier
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221015, XrefRangeEnd = 1221017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startDelayMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221017, XrefRangeEnd = 1221019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startDelayMultiplier_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000146 RID: 326 RVA: 0x00009104 File Offset: 0x00007304
			// (set) Token: 0x06000147 RID: 327 RVA: 0x00009148 File Offset: 0x00007348
			public unsafe float startLifetimeMultiplier
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221019, XrefRangeEnd = 1221021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startLifetimeMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221021, XrefRangeEnd = 1221023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startLifetimeMultiplier_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000148 RID: 328 RVA: 0x0000918C File Offset: 0x0000738C
			// (set) Token: 0x06000149 RID: 329 RVA: 0x000091D0 File Offset: 0x000073D0
			public unsafe float startSpeedMultiplier
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221023, XrefRangeEnd = 1221025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startSpeedMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221025, XrefRangeEnd = 1221027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSpeedMultiplier_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x0600014A RID: 330 RVA: 0x00009214 File Offset: 0x00007414
			// (set) Token: 0x0600014B RID: 331 RVA: 0x00009258 File Offset: 0x00007458
			public unsafe float startSizeMultiplier
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221027, XrefRangeEnd = 1221029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startSizeMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221029, XrefRangeEnd = 1221031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSizeMultiplier_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x0600014C RID: 332 RVA: 0x0000929C File Offset: 0x0000749C
			// (set) Token: 0x0600014D RID: 333 RVA: 0x000092E0 File Offset: 0x000074E0
			public unsafe float startRotationMultiplier
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221031, XrefRangeEnd = 1221033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221033, XrefRangeEnd = 1221035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationMultiplier_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x0600014E RID: 334 RVA: 0x00009324 File Offset: 0x00007524
			// (set) Token: 0x0600014F RID: 335 RVA: 0x00009368 File Offset: 0x00007568
			public unsafe float startRotationXMultiplier
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221035, XrefRangeEnd = 1221037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationXMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221037, XrefRangeEnd = 1221039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationXMultiplier_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000150 RID: 336 RVA: 0x000093AC File Offset: 0x000075AC
			// (set) Token: 0x06000151 RID: 337 RVA: 0x000093F0 File Offset: 0x000075F0
			public unsafe float startRotationYMultiplier
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221039, XrefRangeEnd = 1221041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationYMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221041, XrefRangeEnd = 1221043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationYMultiplier_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x06000152 RID: 338 RVA: 0x00009434 File Offset: 0x00007634
			// (set) Token: 0x06000153 RID: 339 RVA: 0x00009478 File Offset: 0x00007678
			public unsafe float startRotationZMultiplier
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221043, XrefRangeEnd = 1221045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationZMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221045, XrefRangeEnd = 1221047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationZMultiplier_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000154 RID: 340 RVA: 0x000094BC File Offset: 0x000076BC
			// (set) Token: 0x06000155 RID: 341 RVA: 0x000094F8 File Offset: 0x000076F8
			public unsafe ParticleSystem.MinMaxGradient startColor
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221047, XrefRangeEnd = 1221049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startColor_Public_get_MinMaxGradient_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ParticleSystem.MinMaxGradient(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221049, XrefRangeEnd = 1221051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startColor_Public_set_Void_MinMaxGradient_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x06000156 RID: 342 RVA: 0x00009544 File Offset: 0x00007744
			// (set) Token: 0x06000157 RID: 343 RVA: 0x00009588 File Offset: 0x00007788
			public unsafe float gravityModifierMultiplier
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221051, XrefRangeEnd = 1221053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_gravityModifierMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221053, XrefRangeEnd = 1221055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_gravityModifierMultiplier_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000158 RID: 344 RVA: 0x000095CC File Offset: 0x000077CC
			// (set) Token: 0x06000159 RID: 345 RVA: 0x00009610 File Offset: 0x00007810
			public unsafe ParticleSystemSimulationSpace simulationSpace
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221055, XrefRangeEnd = 1221057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_simulationSpace_Public_get_ParticleSystemSimulationSpace_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221057, XrefRangeEnd = 1221059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_simulationSpace_Public_set_Void_ParticleSystemSimulationSpace_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x0600015A RID: 346 RVA: 0x00009654 File Offset: 0x00007854
			// (set) Token: 0x0600015B RID: 347 RVA: 0x00009698 File Offset: 0x00007898
			public unsafe float simulationSpeed
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221059, XrefRangeEnd = 1221061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_simulationSpeed_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221061, XrefRangeEnd = 1221063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_simulationSpeed_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x0600015C RID: 348 RVA: 0x000096DC File Offset: 0x000078DC
			// (set) Token: 0x0600015D RID: 349 RVA: 0x00009720 File Offset: 0x00007920
			public unsafe ParticleSystemScalingMode scalingMode
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221063, XrefRangeEnd = 1221065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_scalingMode_Public_get_ParticleSystemScalingMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221065, XrefRangeEnd = 1221067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_scalingMode_Public_set_Void_ParticleSystemScalingMode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x0600015E RID: 350 RVA: 0x00009764 File Offset: 0x00007964
			// (set) Token: 0x0600015F RID: 351 RVA: 0x000097A8 File Offset: 0x000079A8
			public unsafe bool playOnAwake
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221067, XrefRangeEnd = 1221069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221069, XrefRangeEnd = 1221071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x06000160 RID: 352 RVA: 0x000097EC File Offset: 0x000079EC
			// (set) Token: 0x06000161 RID: 353 RVA: 0x00009830 File Offset: 0x00007A30
			public unsafe int maxParticles
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221071, XrefRangeEnd = 1221073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_maxParticles_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221073, XrefRangeEnd = 1221075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_maxParticles_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000075 RID: 117
			// (set) Token: 0x06000162 RID: 354 RVA: 0x00009874 File Offset: 0x00007A74
			public unsafe ParticleSystemStopAction stopAction
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1221077, RefRangeEnd = 1221078, XrefRangeStart = 1221075, XrefRangeEnd = 1221077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_stopAction_Public_set_Void_ParticleSystemStopAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000163 RID: 355 RVA: 0x000098B8 File Offset: 0x00007AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float get_duration_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_duration_Injected_Private_Static_Single_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000164 RID: 356 RVA: 0x000098FC File Offset: 0x00007AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool get_loop_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_loop_Injected_Private_Static_Boolean_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000165 RID: 357 RVA: 0x00009940 File Offset: 0x00007B40
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1221014, RefRangeEnd = 1221015, XrefRangeStart = 1221014, XrefRangeEnd = 1221015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_loop_Injected(ref ParticleSystem.MainModule _unity_self, bool value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_loop_Injected_Private_Static_Void_byref_MainModule_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000166 RID: 358 RVA: 0x00009988 File Offset: 0x00007B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float get_startDelayMultiplier_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startDelayMultiplier_Injected_Private_Static_Single_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000167 RID: 359 RVA: 0x000099CC File Offset: 0x00007BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_startDelayMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startDelayMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000168 RID: 360 RVA: 0x00009A14 File Offset: 0x00007C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float get_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startLifetimeMultiplier_Injected_Private_Static_Single_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000169 RID: 361 RVA: 0x00009A58 File Offset: 0x00007C58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startLifetimeMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600016A RID: 362 RVA: 0x00009AA0 File Offset: 0x00007CA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float get_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startSpeedMultiplier_Injected_Private_Static_Single_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600016B RID: 363 RVA: 0x00009AE4 File Offset: 0x00007CE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSpeedMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600016C RID: 364 RVA: 0x00009B2C File Offset: 0x00007D2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float get_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startSizeMultiplier_Injected_Private_Static_Single_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600016D RID: 365 RVA: 0x00009B70 File Offset: 0x00007D70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startSizeMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600016E RID: 366 RVA: 0x00009BB8 File Offset: 0x00007DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float get_startRotationMultiplier_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationMultiplier_Injected_Private_Static_Single_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600016F RID: 367 RVA: 0x00009BFC File Offset: 0x00007DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_startRotationMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000170 RID: 368 RVA: 0x00009C44 File Offset: 0x00007E44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float get_startRotationXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationXMultiplier_Injected_Private_Static_Single_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000171 RID: 369 RVA: 0x00009C88 File Offset: 0x00007E88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_startRotationXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationXMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000172 RID: 370 RVA: 0x00009CD0 File Offset: 0x00007ED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float get_startRotationYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationYMultiplier_Injected_Private_Static_Single_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000173 RID: 371 RVA: 0x00009D14 File Offset: 0x00007F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_startRotationYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationYMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000174 RID: 372 RVA: 0x00009D5C File Offset: 0x00007F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float get_startRotationZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startRotationZMultiplier_Injected_Private_Static_Single_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000175 RID: 373 RVA: 0x00009DA0 File Offset: 0x00007FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_startRotationZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startRotationZMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000176 RID: 374 RVA: 0x00009DE8 File Offset: 0x00007FE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221078, XrefRangeEnd = 1221080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void get_startColor_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradient ret)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_startColor_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxGradient_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				ret = ((intPtr4 == 0) ? null : new ParticleSystem.MinMaxGradient(intPtr4));
			}

			// Token: 0x06000177 RID: 375 RVA: 0x00009E40 File Offset: 0x00008040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221080, XrefRangeEnd = 1221082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_startColor_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxGradient value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_startColor_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxGradient_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000178 RID: 376 RVA: 0x00009E8C File Offset: 0x0000808C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float get_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_gravityModifierMultiplier_Injected_Private_Static_Single_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000179 RID: 377 RVA: 0x00009ED0 File Offset: 0x000080D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_gravityModifierMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600017A RID: 378 RVA: 0x00009F18 File Offset: 0x00008118
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ParticleSystemSimulationSpace get_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_simulationSpace_Injected_Private_Static_ParticleSystemSimulationSpace_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600017B RID: 379 RVA: 0x00009F5C File Offset: 0x0000815C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemSimulationSpace value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_simulationSpace_Injected_Private_Static_Void_byref_MainModule_ParticleSystemSimulationSpace_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600017C RID: 380 RVA: 0x00009FA4 File Offset: 0x000081A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float get_simulationSpeed_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_simulationSpeed_Injected_Private_Static_Single_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600017D RID: 381 RVA: 0x00009FE8 File Offset: 0x000081E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_simulationSpeed_Injected(ref ParticleSystem.MainModule _unity_self, float value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_simulationSpeed_Injected_Private_Static_Void_byref_MainModule_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600017E RID: 382 RVA: 0x0000A030 File Offset: 0x00008230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static ParticleSystemScalingMode get_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_scalingMode_Injected_Private_Static_ParticleSystemScalingMode_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600017F RID: 383 RVA: 0x0000A074 File Offset: 0x00008274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemScalingMode value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_scalingMode_Injected_Private_Static_Void_byref_MainModule_ParticleSystemScalingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000180 RID: 384 RVA: 0x0000A0BC File Offset: 0x000082BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool get_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_playOnAwake_Injected_Private_Static_Boolean_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000181 RID: 385 RVA: 0x0000A100 File Offset: 0x00008300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self, bool value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_playOnAwake_Injected_Private_Static_Void_byref_MainModule_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000182 RID: 386 RVA: 0x0000A148 File Offset: 0x00008348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int get_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_get_maxParticles_Injected_Private_Static_Int32_byref_MainModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000183 RID: 387 RVA: 0x0000A18C File Offset: 0x0000838C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self, int value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_maxParticles_Injected_Private_Static_Void_byref_MainModule_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000184 RID: 388 RVA: 0x0000A1D4 File Offset: 0x000083D4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1221077, RefRangeEnd = 1221078, XrefRangeStart = 1221077, XrefRangeEnd = 1221078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_stopAction_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemStopAction value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MainModule.NativeMethodInfoPtr_set_stopAction_Injected_Private_Static_Void_byref_MainModule_ParticleSystemStopAction_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000185 RID: 389 RVA: 0x00002375 File Offset: 0x00000575
			public MainModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000186 RID: 390 RVA: 0x0000237E File Offset: 0x0000057E
			public MainModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MainModule>.NativeClassPtr))
			{
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000187 RID: 391 RVA: 0x0000A21C File Offset: 0x0000841C
			// (set) Token: 0x06000188 RID: 392 RVA: 0x00002390 File Offset: 0x00000590
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MainModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MainModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000247 RID: 583
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000248 RID: 584
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;

			// Token: 0x04000249 RID: 585
			private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_get_Single_0;

			// Token: 0x0400024A RID: 586
			private static readonly IntPtr NativeMethodInfoPtr_get_loop_Public_get_Boolean_0;

			// Token: 0x0400024B RID: 587
			private static readonly IntPtr NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0;

			// Token: 0x0400024C RID: 588
			private static readonly IntPtr NativeMethodInfoPtr_get_startDelayMultiplier_Public_get_Single_0;

			// Token: 0x0400024D RID: 589
			private static readonly IntPtr NativeMethodInfoPtr_set_startDelayMultiplier_Public_set_Void_Single_0;

			// Token: 0x0400024E RID: 590
			private static readonly IntPtr NativeMethodInfoPtr_get_startLifetimeMultiplier_Public_get_Single_0;

			// Token: 0x0400024F RID: 591
			private static readonly IntPtr NativeMethodInfoPtr_set_startLifetimeMultiplier_Public_set_Void_Single_0;

			// Token: 0x04000250 RID: 592
			private static readonly IntPtr NativeMethodInfoPtr_get_startSpeedMultiplier_Public_get_Single_0;

			// Token: 0x04000251 RID: 593
			private static readonly IntPtr NativeMethodInfoPtr_set_startSpeedMultiplier_Public_set_Void_Single_0;

			// Token: 0x04000252 RID: 594
			private static readonly IntPtr NativeMethodInfoPtr_get_startSizeMultiplier_Public_get_Single_0;

			// Token: 0x04000253 RID: 595
			private static readonly IntPtr NativeMethodInfoPtr_set_startSizeMultiplier_Public_set_Void_Single_0;

			// Token: 0x04000254 RID: 596
			private static readonly IntPtr NativeMethodInfoPtr_get_startRotationMultiplier_Public_get_Single_0;

			// Token: 0x04000255 RID: 597
			private static readonly IntPtr NativeMethodInfoPtr_set_startRotationMultiplier_Public_set_Void_Single_0;

			// Token: 0x04000256 RID: 598
			private static readonly IntPtr NativeMethodInfoPtr_get_startRotationXMultiplier_Public_get_Single_0;

			// Token: 0x04000257 RID: 599
			private static readonly IntPtr NativeMethodInfoPtr_set_startRotationXMultiplier_Public_set_Void_Single_0;

			// Token: 0x04000258 RID: 600
			private static readonly IntPtr NativeMethodInfoPtr_get_startRotationYMultiplier_Public_get_Single_0;

			// Token: 0x04000259 RID: 601
			private static readonly IntPtr NativeMethodInfoPtr_set_startRotationYMultiplier_Public_set_Void_Single_0;

			// Token: 0x0400025A RID: 602
			private static readonly IntPtr NativeMethodInfoPtr_get_startRotationZMultiplier_Public_get_Single_0;

			// Token: 0x0400025B RID: 603
			private static readonly IntPtr NativeMethodInfoPtr_set_startRotationZMultiplier_Public_set_Void_Single_0;

			// Token: 0x0400025C RID: 604
			private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Public_get_MinMaxGradient_0;

			// Token: 0x0400025D RID: 605
			private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_MinMaxGradient_0;

			// Token: 0x0400025E RID: 606
			private static readonly IntPtr NativeMethodInfoPtr_get_gravityModifierMultiplier_Public_get_Single_0;

			// Token: 0x0400025F RID: 607
			private static readonly IntPtr NativeMethodInfoPtr_set_gravityModifierMultiplier_Public_set_Void_Single_0;

			// Token: 0x04000260 RID: 608
			private static readonly IntPtr NativeMethodInfoPtr_get_simulationSpace_Public_get_ParticleSystemSimulationSpace_0;

			// Token: 0x04000261 RID: 609
			private static readonly IntPtr NativeMethodInfoPtr_set_simulationSpace_Public_set_Void_ParticleSystemSimulationSpace_0;

			// Token: 0x04000262 RID: 610
			private static readonly IntPtr NativeMethodInfoPtr_get_simulationSpeed_Public_get_Single_0;

			// Token: 0x04000263 RID: 611
			private static readonly IntPtr NativeMethodInfoPtr_set_simulationSpeed_Public_set_Void_Single_0;

			// Token: 0x04000264 RID: 612
			private static readonly IntPtr NativeMethodInfoPtr_get_scalingMode_Public_get_ParticleSystemScalingMode_0;

			// Token: 0x04000265 RID: 613
			private static readonly IntPtr NativeMethodInfoPtr_set_scalingMode_Public_set_Void_ParticleSystemScalingMode_0;

			// Token: 0x04000266 RID: 614
			private static readonly IntPtr NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0;

			// Token: 0x04000267 RID: 615
			private static readonly IntPtr NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0;

			// Token: 0x04000268 RID: 616
			private static readonly IntPtr NativeMethodInfoPtr_get_maxParticles_Public_get_Int32_0;

			// Token: 0x04000269 RID: 617
			private static readonly IntPtr NativeMethodInfoPtr_set_maxParticles_Public_set_Void_Int32_0;

			// Token: 0x0400026A RID: 618
			private static readonly IntPtr NativeMethodInfoPtr_set_stopAction_Public_set_Void_ParticleSystemStopAction_0;

			// Token: 0x0400026B RID: 619
			private static readonly IntPtr NativeMethodInfoPtr_get_duration_Injected_Private_Static_Single_byref_MainModule_0;

			// Token: 0x0400026C RID: 620
			private static readonly IntPtr NativeMethodInfoPtr_get_loop_Injected_Private_Static_Boolean_byref_MainModule_0;

			// Token: 0x0400026D RID: 621
			private static readonly IntPtr NativeMethodInfoPtr_set_loop_Injected_Private_Static_Void_byref_MainModule_Boolean_0;

			// Token: 0x0400026E RID: 622
			private static readonly IntPtr NativeMethodInfoPtr_get_startDelayMultiplier_Injected_Private_Static_Single_byref_MainModule_0;

			// Token: 0x0400026F RID: 623
			private static readonly IntPtr NativeMethodInfoPtr_set_startDelayMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0;

			// Token: 0x04000270 RID: 624
			private static readonly IntPtr NativeMethodInfoPtr_get_startLifetimeMultiplier_Injected_Private_Static_Single_byref_MainModule_0;

			// Token: 0x04000271 RID: 625
			private static readonly IntPtr NativeMethodInfoPtr_set_startLifetimeMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0;

			// Token: 0x04000272 RID: 626
			private static readonly IntPtr NativeMethodInfoPtr_get_startSpeedMultiplier_Injected_Private_Static_Single_byref_MainModule_0;

			// Token: 0x04000273 RID: 627
			private static readonly IntPtr NativeMethodInfoPtr_set_startSpeedMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0;

			// Token: 0x04000274 RID: 628
			private static readonly IntPtr NativeMethodInfoPtr_get_startSizeMultiplier_Injected_Private_Static_Single_byref_MainModule_0;

			// Token: 0x04000275 RID: 629
			private static readonly IntPtr NativeMethodInfoPtr_set_startSizeMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0;

			// Token: 0x04000276 RID: 630
			private static readonly IntPtr NativeMethodInfoPtr_get_startRotationMultiplier_Injected_Private_Static_Single_byref_MainModule_0;

			// Token: 0x04000277 RID: 631
			private static readonly IntPtr NativeMethodInfoPtr_set_startRotationMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0;

			// Token: 0x04000278 RID: 632
			private static readonly IntPtr NativeMethodInfoPtr_get_startRotationXMultiplier_Injected_Private_Static_Single_byref_MainModule_0;

			// Token: 0x04000279 RID: 633
			private static readonly IntPtr NativeMethodInfoPtr_set_startRotationXMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0;

			// Token: 0x0400027A RID: 634
			private static readonly IntPtr NativeMethodInfoPtr_get_startRotationYMultiplier_Injected_Private_Static_Single_byref_MainModule_0;

			// Token: 0x0400027B RID: 635
			private static readonly IntPtr NativeMethodInfoPtr_set_startRotationYMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0;

			// Token: 0x0400027C RID: 636
			private static readonly IntPtr NativeMethodInfoPtr_get_startRotationZMultiplier_Injected_Private_Static_Single_byref_MainModule_0;

			// Token: 0x0400027D RID: 637
			private static readonly IntPtr NativeMethodInfoPtr_set_startRotationZMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0;

			// Token: 0x0400027E RID: 638
			private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxGradient_0;

			// Token: 0x0400027F RID: 639
			private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Injected_Private_Static_Void_byref_MainModule_byref_MinMaxGradient_0;

			// Token: 0x04000280 RID: 640
			private static readonly IntPtr NativeMethodInfoPtr_get_gravityModifierMultiplier_Injected_Private_Static_Single_byref_MainModule_0;

			// Token: 0x04000281 RID: 641
			private static readonly IntPtr NativeMethodInfoPtr_set_gravityModifierMultiplier_Injected_Private_Static_Void_byref_MainModule_Single_0;

			// Token: 0x04000282 RID: 642
			private static readonly IntPtr NativeMethodInfoPtr_get_simulationSpace_Injected_Private_Static_ParticleSystemSimulationSpace_byref_MainModule_0;

			// Token: 0x04000283 RID: 643
			private static readonly IntPtr NativeMethodInfoPtr_set_simulationSpace_Injected_Private_Static_Void_byref_MainModule_ParticleSystemSimulationSpace_0;

			// Token: 0x04000284 RID: 644
			private static readonly IntPtr NativeMethodInfoPtr_get_simulationSpeed_Injected_Private_Static_Single_byref_MainModule_0;

			// Token: 0x04000285 RID: 645
			private static readonly IntPtr NativeMethodInfoPtr_set_simulationSpeed_Injected_Private_Static_Void_byref_MainModule_Single_0;

			// Token: 0x04000286 RID: 646
			private static readonly IntPtr NativeMethodInfoPtr_get_scalingMode_Injected_Private_Static_ParticleSystemScalingMode_byref_MainModule_0;

			// Token: 0x04000287 RID: 647
			private static readonly IntPtr NativeMethodInfoPtr_set_scalingMode_Injected_Private_Static_Void_byref_MainModule_ParticleSystemScalingMode_0;

			// Token: 0x04000288 RID: 648
			private static readonly IntPtr NativeMethodInfoPtr_get_playOnAwake_Injected_Private_Static_Boolean_byref_MainModule_0;

			// Token: 0x04000289 RID: 649
			private static readonly IntPtr NativeMethodInfoPtr_set_playOnAwake_Injected_Private_Static_Void_byref_MainModule_Boolean_0;

			// Token: 0x0400028A RID: 650
			private static readonly IntPtr NativeMethodInfoPtr_get_maxParticles_Injected_Private_Static_Int32_byref_MainModule_0;

			// Token: 0x0400028B RID: 651
			private static readonly IntPtr NativeMethodInfoPtr_set_maxParticles_Injected_Private_Static_Void_byref_MainModule_Int32_0;

			// Token: 0x0400028C RID: 652
			private static readonly IntPtr NativeMethodInfoPtr_set_stopAction_Injected_Private_Static_Void_byref_MainModule_ParticleSystemStopAction_0;
		}

		// Token: 0x0200003F RID: 63
		public sealed class EmissionModule : ValueType
		{
			// Token: 0x06000189 RID: 393 RVA: 0x0000A24C File Offset: 0x0000844C
			// Note: this type is marked as 'beforefieldinit'.
			static EmissionModule()
			{
				Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "EmissionModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr);
				ParticleSystem.EmissionModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.EmissionModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, 100663511);
				ParticleSystem.EmissionModule.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, 100663512);
				ParticleSystem.EmissionModule.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, 100663513);
				ParticleSystem.EmissionModule.NativeMethodInfoPtr_set_rateOverTime_Public_set_Void_MinMaxCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, 100663514);
				ParticleSystem.EmissionModule.NativeMethodInfoPtr_get_rateOverTimeMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, 100663515);
				ParticleSystem.EmissionModule.NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_byref_EmissionModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, 100663516);
				ParticleSystem.EmissionModule.NativeMethodInfoPtr_set_enabled_Injected_Private_Static_Void_byref_EmissionModule_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, 100663517);
				ParticleSystem.EmissionModule.NativeMethodInfoPtr_set_rateOverTime_Injected_Private_Static_Void_byref_EmissionModule_byref_MinMaxCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, 100663518);
				ParticleSystem.EmissionModule.NativeMethodInfoPtr_get_rateOverTimeMultiplier_Injected_Private_Static_Single_byref_EmissionModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr, 100663519);
			}

			// Token: 0x0600018A RID: 394 RVA: 0x0000A340 File Offset: 0x00008540
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmissionModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.EmissionModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x0600018B RID: 395 RVA: 0x0000A390 File Offset: 0x00008590
			// (set) Token: 0x0600018C RID: 396 RVA: 0x0000A3D4 File Offset: 0x000085D4
			public unsafe bool enabled
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221082, XrefRangeEnd = 1221084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.EmissionModule.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1221086, RefRangeEnd = 1221087, XrefRangeStart = 1221084, XrefRangeEnd = 1221086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.EmissionModule.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000078 RID: 120
			// (set) Token: 0x0600018D RID: 397 RVA: 0x0000A418 File Offset: 0x00008618
			public unsafe ParticleSystem.MinMaxCurve rateOverTime
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1221089, RefRangeEnd = 1221090, XrefRangeStart = 1221087, XrefRangeEnd = 1221089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.EmissionModule.NativeMethodInfoPtr_set_rateOverTime_Public_set_Void_MinMaxCurve_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x0600018E RID: 398 RVA: 0x0000A464 File Offset: 0x00008664
			public unsafe float rateOverTimeMultiplier
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221090, XrefRangeEnd = 1221092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.EmissionModule.NativeMethodInfoPtr_get_rateOverTimeMultiplier_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600018F RID: 399 RVA: 0x0000A4A8 File Offset: 0x000086A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool get_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.EmissionModule.NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_byref_EmissionModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000190 RID: 400 RVA: 0x0000A4EC File Offset: 0x000086EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1221086, RefRangeEnd = 1221087, XrefRangeStart = 1221086, XrefRangeEnd = 1221087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self, bool value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.EmissionModule.NativeMethodInfoPtr_set_enabled_Injected_Private_Static_Void_byref_EmissionModule_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000191 RID: 401 RVA: 0x0000A534 File Offset: 0x00008734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221092, XrefRangeEnd = 1221094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void set_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.EmissionModule.NativeMethodInfoPtr_set_rateOverTime_Injected_Private_Static_Void_byref_EmissionModule_byref_MinMaxCurve_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000192 RID: 402 RVA: 0x0000A580 File Offset: 0x00008780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static float get_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(_unity_self);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.EmissionModule.NativeMethodInfoPtr_get_rateOverTimeMultiplier_Injected_Private_Static_Single_byref_EmissionModule_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000193 RID: 403 RVA: 0x000023AF File Offset: 0x000005AF
			public EmissionModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000194 RID: 404 RVA: 0x000023B8 File Offset: 0x000005B8
			public EmissionModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.EmissionModule>.NativeClassPtr))
			{
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x06000195 RID: 405 RVA: 0x0000A5C4 File Offset: 0x000087C4
			// (set) Token: 0x06000196 RID: 406 RVA: 0x000023CA File Offset: 0x000005CA
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.EmissionModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.EmissionModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400028D RID: 653
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x0400028E RID: 654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;

			// Token: 0x0400028F RID: 655
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

			// Token: 0x04000290 RID: 656
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

			// Token: 0x04000291 RID: 657
			private static readonly IntPtr NativeMethodInfoPtr_set_rateOverTime_Public_set_Void_MinMaxCurve_0;

			// Token: 0x04000292 RID: 658
			private static readonly IntPtr NativeMethodInfoPtr_get_rateOverTimeMultiplier_Public_get_Single_0;

			// Token: 0x04000293 RID: 659
			private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_byref_EmissionModule_0;

			// Token: 0x04000294 RID: 660
			private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Injected_Private_Static_Void_byref_EmissionModule_Boolean_0;

			// Token: 0x04000295 RID: 661
			private static readonly IntPtr NativeMethodInfoPtr_set_rateOverTime_Injected_Private_Static_Void_byref_EmissionModule_byref_MinMaxCurve_0;

			// Token: 0x04000296 RID: 662
			private static readonly IntPtr NativeMethodInfoPtr_get_rateOverTimeMultiplier_Injected_Private_Static_Single_byref_EmissionModule_0;
		}

		// Token: 0x02000040 RID: 64
		public sealed class ShapeModule : ValueType
		{
			// Token: 0x06000197 RID: 407 RVA: 0x0000A5F4 File Offset: 0x000087F4
			// Note: this type is marked as 'beforefieldinit'.
			static ShapeModule()
			{
				Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "ShapeModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr);
				ParticleSystem.ShapeModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.ShapeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr, 100663520);
			}

			// Token: 0x06000198 RID: 408 RVA: 0x0000A648 File Offset: 0x00008848
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShapeModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.ShapeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000199 RID: 409 RVA: 0x000023E9 File Offset: 0x000005E9
			public ShapeModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600019A RID: 410 RVA: 0x000023F2 File Offset: 0x000005F2
			public ShapeModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.ShapeModule>.NativeClassPtr))
			{
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x0600019B RID: 411 RVA: 0x0000A698 File Offset: 0x00008898
			// (set) Token: 0x0600019C RID: 412 RVA: 0x00002404 File Offset: 0x00000604
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.ShapeModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.ShapeModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000297 RID: 663
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000298 RID: 664
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000041 RID: 65
		public sealed class CollisionModule : ValueType
		{
			// Token: 0x0600019D RID: 413 RVA: 0x0000A6C8 File Offset: 0x000088C8
			// Note: this type is marked as 'beforefieldinit'.
			static CollisionModule()
			{
				Il2CppClassPointerStore<ParticleSystem.CollisionModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "CollisionModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.CollisionModule>.NativeClassPtr);
				ParticleSystem.CollisionModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.CollisionModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.CollisionModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.CollisionModule>.NativeClassPtr, 100663521);
			}

			// Token: 0x0600019E RID: 414 RVA: 0x0000A71C File Offset: 0x0000891C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CollisionModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.CollisionModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.CollisionModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600019F RID: 415 RVA: 0x00002423 File Offset: 0x00000623
			public CollisionModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x0000242C File Offset: 0x0000062C
			public CollisionModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.CollisionModule>.NativeClassPtr))
			{
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000A76C File Offset: 0x0000896C
			// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000243E File Offset: 0x0000063E
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.CollisionModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.CollisionModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000299 RID: 665
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x0400029A RID: 666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000042 RID: 66
		public sealed class TriggerModule : ValueType
		{
			// Token: 0x060001A3 RID: 419 RVA: 0x0000A79C File Offset: 0x0000899C
			// Note: this type is marked as 'beforefieldinit'.
			static TriggerModule()
			{
				Il2CppClassPointerStore<ParticleSystem.TriggerModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "TriggerModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.TriggerModule>.NativeClassPtr);
				ParticleSystem.TriggerModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.TriggerModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.TriggerModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TriggerModule>.NativeClassPtr, 100663522);
			}

			// Token: 0x060001A4 RID: 420 RVA: 0x0000A7F0 File Offset: 0x000089F0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TriggerModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.TriggerModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TriggerModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001A5 RID: 421 RVA: 0x0000245D File Offset: 0x0000065D
			public TriggerModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001A6 RID: 422 RVA: 0x00002466 File Offset: 0x00000666
			public TriggerModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.TriggerModule>.NativeClassPtr))
			{
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000A840 File Offset: 0x00008A40
			// (set) Token: 0x060001A8 RID: 424 RVA: 0x00002478 File Offset: 0x00000678
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.TriggerModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.TriggerModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400029B RID: 667
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x0400029C RID: 668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000043 RID: 67
		public sealed class SubEmittersModule : ValueType
		{
			// Token: 0x060001A9 RID: 425 RVA: 0x0000A870 File Offset: 0x00008A70
			// Note: this type is marked as 'beforefieldinit'.
			static SubEmittersModule()
			{
				Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "SubEmittersModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr);
				ParticleSystem.SubEmittersModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.SubEmittersModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr, 100663523);
			}

			// Token: 0x060001AA RID: 426 RVA: 0x0000A8C4 File Offset: 0x00008AC4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SubEmittersModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.SubEmittersModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001AB RID: 427 RVA: 0x00002497 File Offset: 0x00000697
			public SubEmittersModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001AC RID: 428 RVA: 0x000024A0 File Offset: 0x000006A0
			public SubEmittersModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.SubEmittersModule>.NativeClassPtr))
			{
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060001AD RID: 429 RVA: 0x0000A914 File Offset: 0x00008B14
			// (set) Token: 0x060001AE RID: 430 RVA: 0x000024B2 File Offset: 0x000006B2
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.SubEmittersModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.SubEmittersModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400029D RID: 669
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x0400029E RID: 670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000044 RID: 68
		public sealed class TextureSheetAnimationModule : ValueType
		{
			// Token: 0x060001AF RID: 431 RVA: 0x0000A944 File Offset: 0x00008B44
			// Note: this type is marked as 'beforefieldinit'.
			static TextureSheetAnimationModule()
			{
				Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "TextureSheetAnimationModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr);
				ParticleSystem.TextureSheetAnimationModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr, 100663524);
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x0000A998 File Offset: 0x00008B98
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextureSheetAnimationModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TextureSheetAnimationModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x000024D1 File Offset: 0x000006D1
			public TextureSheetAnimationModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x000024DA File Offset: 0x000006DA
			public TextureSheetAnimationModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.TextureSheetAnimationModule>.NativeClassPtr))
			{
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000A9E8 File Offset: 0x00008BE8
			// (set) Token: 0x060001B4 RID: 436 RVA: 0x000024EC File Offset: 0x000006EC
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.TextureSheetAnimationModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.TextureSheetAnimationModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400029F RID: 671
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x040002A0 RID: 672
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000045 RID: 69
		[StructLayout(2)]
		public struct Particle
		{
			// Token: 0x060001B5 RID: 437 RVA: 0x0000AA18 File Offset: 0x00008C18
			// Note: this type is marked as 'beforefieldinit'.
			static Particle()
			{
				Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "Particle");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr);
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Position");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Velocity");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_AnimatedVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_AnimatedVelocity");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_InitialVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_InitialVelocity");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_AxisOfRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_AxisOfRotation");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Rotation");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_AngularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_AngularVelocity");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_StartSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_StartSize");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_StartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_StartColor");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_RandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_RandomSeed");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_ParentRandomSeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_ParentRandomSeed");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Lifetime");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_StartLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_StartLifetime");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_MeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_MeshIndex");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_EmitAccumulator0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_EmitAccumulator0");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_EmitAccumulator1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_EmitAccumulator1");
				ParticleSystem.Particle.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, "m_Flags");
				ParticleSystem.Particle.NativeMethodInfoPtr_set_lifetime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663525);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663526);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663527);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_remainingLifetime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663528);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663529);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663530);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663531);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_startSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663532);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_rotation3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663533);
				ParticleSystem.Particle.NativeMethodInfoPtr_set_angularVelocity3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, 100663534);
			}

			// Token: 0x1700007F RID: 127
			// (set) Token: 0x060001B6 RID: 438 RVA: 0x0000AC60 File Offset: 0x00008E60
			public unsafe float lifetime
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_lifetime_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000080 RID: 128
			// (set) Token: 0x060001B7 RID: 439 RVA: 0x0000AC94 File Offset: 0x00008E94
			public unsafe Vector3 position
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000081 RID: 129
			// (set) Token: 0x060001B8 RID: 440 RVA: 0x0000ACC8 File Offset: 0x00008EC8
			public unsafe Vector3 velocity
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000082 RID: 130
			// (set) Token: 0x060001B9 RID: 441 RVA: 0x0000ACFC File Offset: 0x00008EFC
			public unsafe float remainingLifetime
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_remainingLifetime_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000083 RID: 131
			// (set) Token: 0x060001BA RID: 442 RVA: 0x0000AD30 File Offset: 0x00008F30
			public unsafe float startLifetime
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000084 RID: 132
			// (set) Token: 0x060001BB RID: 443 RVA: 0x0000AD64 File Offset: 0x00008F64
			public unsafe Color32 startColor
			{
				[CallerCount(16)]
				[CachedScanResults(RefRangeStart = 312518, RefRangeEnd = 312534, XrefRangeStart = 312518, XrefRangeEnd = 312534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000085 RID: 133
			// (set) Token: 0x060001BC RID: 444 RVA: 0x0000AD98 File Offset: 0x00008F98
			public unsafe uint randomSeed
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 345981, RefRangeEnd = 345986, XrefRangeStart = 345981, XrefRangeEnd = 345986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000086 RID: 134
			// (set) Token: 0x060001BD RID: 445 RVA: 0x0000ADCC File Offset: 0x00008FCC
			public unsafe float startSize
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_startSize_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000087 RID: 135
			// (set) Token: 0x060001BE RID: 446 RVA: 0x0000AE00 File Offset: 0x00009000
			public unsafe Vector3 rotation3D
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_rotation3D_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000088 RID: 136
			// (set) Token: 0x060001BF RID: 447 RVA: 0x0000AE34 File Offset: 0x00009034
			public unsafe Vector3 angularVelocity3D
			{
				[CallerCount(0)]
				set
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Particle.NativeMethodInfoPtr_set_angularVelocity3D_Public_set_Void_Vector3_0, ref this, (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060001C0 RID: 448 RVA: 0x0000250B File Offset: 0x0000070B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.Particle>.NativeClassPtr, ref this));
			}

			// Token: 0x040002A1 RID: 673
			private static readonly IntPtr NativeFieldInfoPtr_m_Position;

			// Token: 0x040002A2 RID: 674
			private static readonly IntPtr NativeFieldInfoPtr_m_Velocity;

			// Token: 0x040002A3 RID: 675
			private static readonly IntPtr NativeFieldInfoPtr_m_AnimatedVelocity;

			// Token: 0x040002A4 RID: 676
			private static readonly IntPtr NativeFieldInfoPtr_m_InitialVelocity;

			// Token: 0x040002A5 RID: 677
			private static readonly IntPtr NativeFieldInfoPtr_m_AxisOfRotation;

			// Token: 0x040002A6 RID: 678
			private static readonly IntPtr NativeFieldInfoPtr_m_Rotation;

			// Token: 0x040002A7 RID: 679
			private static readonly IntPtr NativeFieldInfoPtr_m_AngularVelocity;

			// Token: 0x040002A8 RID: 680
			private static readonly IntPtr NativeFieldInfoPtr_m_StartSize;

			// Token: 0x040002A9 RID: 681
			private static readonly IntPtr NativeFieldInfoPtr_m_StartColor;

			// Token: 0x040002AA RID: 682
			private static readonly IntPtr NativeFieldInfoPtr_m_RandomSeed;

			// Token: 0x040002AB RID: 683
			private static readonly IntPtr NativeFieldInfoPtr_m_ParentRandomSeed;

			// Token: 0x040002AC RID: 684
			private static readonly IntPtr NativeFieldInfoPtr_m_Lifetime;

			// Token: 0x040002AD RID: 685
			private static readonly IntPtr NativeFieldInfoPtr_m_StartLifetime;

			// Token: 0x040002AE RID: 686
			private static readonly IntPtr NativeFieldInfoPtr_m_MeshIndex;

			// Token: 0x040002AF RID: 687
			private static readonly IntPtr NativeFieldInfoPtr_m_EmitAccumulator0;

			// Token: 0x040002B0 RID: 688
			private static readonly IntPtr NativeFieldInfoPtr_m_EmitAccumulator1;

			// Token: 0x040002B1 RID: 689
			private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

			// Token: 0x040002B2 RID: 690
			private static readonly IntPtr NativeMethodInfoPtr_set_lifetime_Public_set_Void_Single_0;

			// Token: 0x040002B3 RID: 691
			private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;

			// Token: 0x040002B4 RID: 692
			private static readonly IntPtr NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector3_0;

			// Token: 0x040002B5 RID: 693
			private static readonly IntPtr NativeMethodInfoPtr_set_remainingLifetime_Public_set_Void_Single_0;

			// Token: 0x040002B6 RID: 694
			private static readonly IntPtr NativeMethodInfoPtr_set_startLifetime_Public_set_Void_Single_0;

			// Token: 0x040002B7 RID: 695
			private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_Color32_0;

			// Token: 0x040002B8 RID: 696
			private static readonly IntPtr NativeMethodInfoPtr_set_randomSeed_Public_set_Void_UInt32_0;

			// Token: 0x040002B9 RID: 697
			private static readonly IntPtr NativeMethodInfoPtr_set_startSize_Public_set_Void_Single_0;

			// Token: 0x040002BA RID: 698
			private static readonly IntPtr NativeMethodInfoPtr_set_rotation3D_Public_set_Void_Vector3_0;

			// Token: 0x040002BB RID: 699
			private static readonly IntPtr NativeMethodInfoPtr_set_angularVelocity3D_Public_set_Void_Vector3_0;

			// Token: 0x040002BC RID: 700
			[FieldOffset(0)]
			public Vector3 m_Position;

			// Token: 0x040002BD RID: 701
			[FieldOffset(12)]
			public Vector3 m_Velocity;

			// Token: 0x040002BE RID: 702
			[FieldOffset(24)]
			public Vector3 m_AnimatedVelocity;

			// Token: 0x040002BF RID: 703
			[FieldOffset(36)]
			public Vector3 m_InitialVelocity;

			// Token: 0x040002C0 RID: 704
			[FieldOffset(48)]
			public Vector3 m_AxisOfRotation;

			// Token: 0x040002C1 RID: 705
			[FieldOffset(60)]
			public Vector3 m_Rotation;

			// Token: 0x040002C2 RID: 706
			[FieldOffset(72)]
			public Vector3 m_AngularVelocity;

			// Token: 0x040002C3 RID: 707
			[FieldOffset(84)]
			public Vector3 m_StartSize;

			// Token: 0x040002C4 RID: 708
			[FieldOffset(96)]
			public Color32 m_StartColor;

			// Token: 0x040002C5 RID: 709
			[FieldOffset(100)]
			public uint m_RandomSeed;

			// Token: 0x040002C6 RID: 710
			[FieldOffset(104)]
			public uint m_ParentRandomSeed;

			// Token: 0x040002C7 RID: 711
			[FieldOffset(108)]
			public float m_Lifetime;

			// Token: 0x040002C8 RID: 712
			[FieldOffset(112)]
			public float m_StartLifetime;

			// Token: 0x040002C9 RID: 713
			[FieldOffset(116)]
			public int m_MeshIndex;

			// Token: 0x040002CA RID: 714
			[FieldOffset(120)]
			public float m_EmitAccumulator0;

			// Token: 0x040002CB RID: 715
			[FieldOffset(124)]
			public float m_EmitAccumulator1;

			// Token: 0x040002CC RID: 716
			[FieldOffset(128)]
			public uint m_Flags;

			// Token: 0x02000086 RID: 134
			public enum Flags
			{
				// Token: 0x04000346 RID: 838
				Size3D = 1,
				// Token: 0x04000347 RID: 839
				Rotation3D,
				// Token: 0x04000348 RID: 840
				MeshIndex = 4
			}
		}

		// Token: 0x02000046 RID: 70
		[Serializable]
		public sealed class MinMaxCurve : ValueType
		{
			// Token: 0x060001C1 RID: 449 RVA: 0x0000AE68 File Offset: 0x00009068
			// Note: this type is marked as 'beforefieldinit'.
			static MinMaxCurve()
			{
				Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "MinMaxCurve");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr);
				ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, "m_Mode");
				ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, "m_CurveMultiplier");
				ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, "m_CurveMin");
				ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, "m_CurveMax");
				ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_ConstantMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, "m_ConstantMin");
				ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_ConstantMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, "m_ConstantMax");
				ParticleSystem.MinMaxCurve.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, 100663535);
				ParticleSystem.MinMaxCurve.NativeMethodInfoPtr_op_Implicit_Public_Static_MinMaxCurve_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr, 100663536);
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x0000AF34 File Offset: 0x00009134
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1221096, RefRangeEnd = 1221097, XrefRangeStart = 1221094, XrefRangeEnd = 1221096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MinMaxCurve(float constant)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref constant;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MinMaxCurve.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x0000AF80 File Offset: 0x00009180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221097, XrefRangeEnd = 1221099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe static implicit operator ParticleSystem.MinMaxCurve(float constant)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref constant;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MinMaxCurve.NativeMethodInfoPtr_op_Implicit_Public_Static_MinMaxCurve_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ParticleSystem.MinMaxCurve(intPtr);
				}
			}

			// Token: 0x060001C4 RID: 452 RVA: 0x0000251D File Offset: 0x0000071D
			public MinMaxCurve(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001C5 RID: 453 RVA: 0x00002526 File Offset: 0x00000726
			public MinMaxCurve()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MinMaxCurve>.NativeClassPtr))
			{
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000AFB8 File Offset: 0x000091B8
			// (set) Token: 0x060001C7 RID: 455 RVA: 0x00002538 File Offset: 0x00000738
			public unsafe ParticleSystemCurveMode m_Mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_Mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_Mode)) = value;
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000AFE0 File Offset: 0x000091E0
			// (set) Token: 0x060001C9 RID: 457 RVA: 0x00002553 File Offset: 0x00000753
			public unsafe float m_CurveMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMultiplier)) = value;
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x060001CA RID: 458 RVA: 0x0000B008 File Offset: 0x00009208
			// (set) Token: 0x060001CB RID: 459 RVA: 0x0000256E File Offset: 0x0000076E
			public unsafe AnimationCurve m_CurveMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMin);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMin), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x060001CC RID: 460 RVA: 0x0000B038 File Offset: 0x00009238
			// (set) Token: 0x060001CD RID: 461 RVA: 0x0000258D File Offset: 0x0000078D
			public unsafe AnimationCurve m_CurveMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMax);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_CurveMax), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x060001CE RID: 462 RVA: 0x0000B068 File Offset: 0x00009268
			// (set) Token: 0x060001CF RID: 463 RVA: 0x000025AC File Offset: 0x000007AC
			public unsafe float m_ConstantMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_ConstantMin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_ConstantMin)) = value;
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000B090 File Offset: 0x00009290
			// (set) Token: 0x060001D1 RID: 465 RVA: 0x000025C7 File Offset: 0x000007C7
			public unsafe float m_ConstantMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_ConstantMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxCurve.NativeFieldInfoPtr_m_ConstantMax)) = value;
				}
			}

			// Token: 0x040002CD RID: 717
			private static readonly IntPtr NativeFieldInfoPtr_m_Mode;

			// Token: 0x040002CE RID: 718
			private static readonly IntPtr NativeFieldInfoPtr_m_CurveMultiplier;

			// Token: 0x040002CF RID: 719
			private static readonly IntPtr NativeFieldInfoPtr_m_CurveMin;

			// Token: 0x040002D0 RID: 720
			private static readonly IntPtr NativeFieldInfoPtr_m_CurveMax;

			// Token: 0x040002D1 RID: 721
			private static readonly IntPtr NativeFieldInfoPtr_m_ConstantMin;

			// Token: 0x040002D2 RID: 722
			private static readonly IntPtr NativeFieldInfoPtr_m_ConstantMax;

			// Token: 0x040002D3 RID: 723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

			// Token: 0x040002D4 RID: 724
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_MinMaxCurve_Single_0;
		}

		// Token: 0x02000047 RID: 71
		[Serializable]
		public sealed class MinMaxGradient : ValueType
		{
			// Token: 0x060001D2 RID: 466 RVA: 0x0000B0B8 File Offset: 0x000092B8
			// Note: this type is marked as 'beforefieldinit'.
			static MinMaxGradient()
			{
				Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "MinMaxGradient");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr);
				ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, "m_Mode");
				ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_GradientMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, "m_GradientMin");
				ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_GradientMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, "m_GradientMax");
				ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_ColorMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, "m_ColorMin");
				ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_ColorMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, "m_ColorMax");
				ParticleSystem.MinMaxGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, 100663537);
				ParticleSystem.MinMaxGradient.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, 100663538);
				ParticleSystem.MinMaxGradient.NativeMethodInfoPtr_op_Implicit_Public_Static_MinMaxGradient_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr, 100663539);
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x0000B184 File Offset: 0x00009384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221099, XrefRangeEnd = 1221101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MinMaxGradient(Color color)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref color;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MinMaxGradient.NativeMethodInfoPtr__ctor_Public_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000B1D0 File Offset: 0x000093D0
			public unsafe Color color
			{
				[CallerCount(18)]
				[CachedScanResults(RefRangeStart = 1221101, RefRangeEnd = 1221119, XrefRangeStart = 1221101, XrefRangeEnd = 1221101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MinMaxGradient.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x0000B214 File Offset: 0x00009414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221119, XrefRangeEnd = 1221121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static implicit operator ParticleSystem.MinMaxGradient(Color color)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref color;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.MinMaxGradient.NativeMethodInfoPtr_op_Implicit_Public_Static_MinMaxGradient_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ParticleSystem.MinMaxGradient(intPtr);
				}
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x000025E2 File Offset: 0x000007E2
			public MinMaxGradient(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x000025EB File Offset: 0x000007EB
			public MinMaxGradient()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.MinMaxGradient>.NativeClassPtr))
			{
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000B24C File Offset: 0x0000944C
			// (set) Token: 0x060001D9 RID: 473 RVA: 0x000025FD File Offset: 0x000007FD
			public unsafe ParticleSystemGradientMode m_Mode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_Mode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_Mode)) = value;
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x060001DA RID: 474 RVA: 0x0000B274 File Offset: 0x00009474
			// (set) Token: 0x060001DB RID: 475 RVA: 0x00002618 File Offset: 0x00000818
			public unsafe Gradient m_GradientMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_GradientMin);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_GradientMin), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x060001DC RID: 476 RVA: 0x0000B2A4 File Offset: 0x000094A4
			// (set) Token: 0x060001DD RID: 477 RVA: 0x00002637 File Offset: 0x00000837
			public unsafe Gradient m_GradientMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_GradientMax);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_GradientMax), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x060001DE RID: 478 RVA: 0x0000B2D4 File Offset: 0x000094D4
			// (set) Token: 0x060001DF RID: 479 RVA: 0x00002656 File Offset: 0x00000856
			public unsafe Color m_ColorMin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_ColorMin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_ColorMin)) = value;
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000B2FC File Offset: 0x000094FC
			// (set) Token: 0x060001E1 RID: 481 RVA: 0x00002671 File Offset: 0x00000871
			public unsafe Color m_ColorMax
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_ColorMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.MinMaxGradient.NativeFieldInfoPtr_m_ColorMax)) = value;
				}
			}

			// Token: 0x040002D5 RID: 725
			private static readonly IntPtr NativeFieldInfoPtr_m_Mode;

			// Token: 0x040002D6 RID: 726
			private static readonly IntPtr NativeFieldInfoPtr_m_GradientMin;

			// Token: 0x040002D7 RID: 727
			private static readonly IntPtr NativeFieldInfoPtr_m_GradientMax;

			// Token: 0x040002D8 RID: 728
			private static readonly IntPtr NativeFieldInfoPtr_m_ColorMin;

			// Token: 0x040002D9 RID: 729
			private static readonly IntPtr NativeFieldInfoPtr_m_ColorMax;

			// Token: 0x040002DA RID: 730
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

			// Token: 0x040002DB RID: 731
			private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;

			// Token: 0x040002DC RID: 732
			private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_MinMaxGradient_Color_0;
		}

		// Token: 0x02000048 RID: 72
		[StructLayout(2)]
		public struct EmitParams
		{
			// Token: 0x060001E2 RID: 482 RVA: 0x0000B324 File Offset: 0x00009524
			// Note: this type is marked as 'beforefieldinit'.
			static EmitParams()
			{
				Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "EmitParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr);
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_Particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_Particle");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_PositionSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_PositionSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_VelocitySet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_VelocitySet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_AxisOfRotationSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_AxisOfRotationSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_RotationSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_RotationSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_AngularVelocitySet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_AngularVelocitySet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_StartSizeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_StartSizeSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_StartColorSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_StartColorSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_RandomSeedSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_RandomSeedSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_StartLifetimeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_StartLifetimeSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_MeshIndexSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_MeshIndexSet");
				ParticleSystem.EmitParams.NativeFieldInfoPtr_m_ApplyShapeToPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, "m_ApplyShapeToPosition");
			}

			// Token: 0x060001E3 RID: 483 RVA: 0x0000268C File Offset: 0x0000088C
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.EmitParams>.NativeClassPtr, ref this));
			}

			// Token: 0x040002DD RID: 733
			private static readonly IntPtr NativeFieldInfoPtr_m_Particle;

			// Token: 0x040002DE RID: 734
			private static readonly IntPtr NativeFieldInfoPtr_m_PositionSet;

			// Token: 0x040002DF RID: 735
			private static readonly IntPtr NativeFieldInfoPtr_m_VelocitySet;

			// Token: 0x040002E0 RID: 736
			private static readonly IntPtr NativeFieldInfoPtr_m_AxisOfRotationSet;

			// Token: 0x040002E1 RID: 737
			private static readonly IntPtr NativeFieldInfoPtr_m_RotationSet;

			// Token: 0x040002E2 RID: 738
			private static readonly IntPtr NativeFieldInfoPtr_m_AngularVelocitySet;

			// Token: 0x040002E3 RID: 739
			private static readonly IntPtr NativeFieldInfoPtr_m_StartSizeSet;

			// Token: 0x040002E4 RID: 740
			private static readonly IntPtr NativeFieldInfoPtr_m_StartColorSet;

			// Token: 0x040002E5 RID: 741
			private static readonly IntPtr NativeFieldInfoPtr_m_RandomSeedSet;

			// Token: 0x040002E6 RID: 742
			private static readonly IntPtr NativeFieldInfoPtr_m_StartLifetimeSet;

			// Token: 0x040002E7 RID: 743
			private static readonly IntPtr NativeFieldInfoPtr_m_MeshIndexSet;

			// Token: 0x040002E8 RID: 744
			private static readonly IntPtr NativeFieldInfoPtr_m_ApplyShapeToPosition;

			// Token: 0x040002E9 RID: 745
			[FieldOffset(0)]
			public ParticleSystem.Particle m_Particle;

			// Token: 0x040002EA RID: 746
			[FieldOffset(132)]
			[MarshalAs(4)]
			public bool m_PositionSet;

			// Token: 0x040002EB RID: 747
			[FieldOffset(133)]
			[MarshalAs(4)]
			public bool m_VelocitySet;

			// Token: 0x040002EC RID: 748
			[FieldOffset(134)]
			[MarshalAs(4)]
			public bool m_AxisOfRotationSet;

			// Token: 0x040002ED RID: 749
			[FieldOffset(135)]
			[MarshalAs(4)]
			public bool m_RotationSet;

			// Token: 0x040002EE RID: 750
			[FieldOffset(136)]
			[MarshalAs(4)]
			public bool m_AngularVelocitySet;

			// Token: 0x040002EF RID: 751
			[FieldOffset(137)]
			[MarshalAs(4)]
			public bool m_StartSizeSet;

			// Token: 0x040002F0 RID: 752
			[FieldOffset(138)]
			[MarshalAs(4)]
			public bool m_StartColorSet;

			// Token: 0x040002F1 RID: 753
			[FieldOffset(139)]
			[MarshalAs(4)]
			public bool m_RandomSeedSet;

			// Token: 0x040002F2 RID: 754
			[FieldOffset(140)]
			[MarshalAs(4)]
			public bool m_StartLifetimeSet;

			// Token: 0x040002F3 RID: 755
			[FieldOffset(141)]
			[MarshalAs(4)]
			public bool m_MeshIndexSet;

			// Token: 0x040002F4 RID: 756
			[FieldOffset(142)]
			[MarshalAs(4)]
			public bool m_ApplyShapeToPosition;
		}

		// Token: 0x02000049 RID: 73
		[StructLayout(2)]
		public struct PlaybackState
		{
			// Token: 0x060001E4 RID: 484 RVA: 0x0000B440 File Offset: 0x00009640
			// Note: this type is marked as 'beforefieldinit'.
			static PlaybackState()
			{
				Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "PlaybackState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr);
				ParticleSystem.PlaybackState.NativeFieldInfoPtr_m_AccumulatedDt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "m_AccumulatedDt");
				ParticleSystem.PlaybackState.NativeFieldInfoPtr_m_StartDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "m_StartDelay");
				ParticleSystem.PlaybackState.NativeFieldInfoPtr_m_PlaybackTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "m_PlaybackTime");
				ParticleSystem.PlaybackState.NativeFieldInfoPtr_m_RingBufferIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "m_RingBufferIndex");
				ParticleSystem.PlaybackState.NativeFieldInfoPtr_m_Emission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "m_Emission");
				ParticleSystem.PlaybackState.NativeFieldInfoPtr_m_Initial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "m_Initial");
				ParticleSystem.PlaybackState.NativeFieldInfoPtr_m_Shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "m_Shape");
				ParticleSystem.PlaybackState.NativeFieldInfoPtr_m_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "m_Force");
				ParticleSystem.PlaybackState.NativeFieldInfoPtr_m_Collision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "m_Collision");
				ParticleSystem.PlaybackState.NativeFieldInfoPtr_m_Noise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "m_Noise");
				ParticleSystem.PlaybackState.NativeFieldInfoPtr_m_Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "m_Lights");
				ParticleSystem.PlaybackState.NativeFieldInfoPtr_m_Trail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "m_Trail");
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x0000269E File Offset: 0x0000089E
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, ref this));
			}

			// Token: 0x040002F5 RID: 757
			private static readonly IntPtr NativeFieldInfoPtr_m_AccumulatedDt;

			// Token: 0x040002F6 RID: 758
			private static readonly IntPtr NativeFieldInfoPtr_m_StartDelay;

			// Token: 0x040002F7 RID: 759
			private static readonly IntPtr NativeFieldInfoPtr_m_PlaybackTime;

			// Token: 0x040002F8 RID: 760
			private static readonly IntPtr NativeFieldInfoPtr_m_RingBufferIndex;

			// Token: 0x040002F9 RID: 761
			private static readonly IntPtr NativeFieldInfoPtr_m_Emission;

			// Token: 0x040002FA RID: 762
			private static readonly IntPtr NativeFieldInfoPtr_m_Initial;

			// Token: 0x040002FB RID: 763
			private static readonly IntPtr NativeFieldInfoPtr_m_Shape;

			// Token: 0x040002FC RID: 764
			private static readonly IntPtr NativeFieldInfoPtr_m_Force;

			// Token: 0x040002FD RID: 765
			private static readonly IntPtr NativeFieldInfoPtr_m_Collision;

			// Token: 0x040002FE RID: 766
			private static readonly IntPtr NativeFieldInfoPtr_m_Noise;

			// Token: 0x040002FF RID: 767
			private static readonly IntPtr NativeFieldInfoPtr_m_Lights;

			// Token: 0x04000300 RID: 768
			private static readonly IntPtr NativeFieldInfoPtr_m_Trail;

			// Token: 0x04000301 RID: 769
			[FieldOffset(0)]
			public float m_AccumulatedDt;

			// Token: 0x04000302 RID: 770
			[FieldOffset(4)]
			public float m_StartDelay;

			// Token: 0x04000303 RID: 771
			[FieldOffset(8)]
			public float m_PlaybackTime;

			// Token: 0x04000304 RID: 772
			[FieldOffset(12)]
			public int m_RingBufferIndex;

			// Token: 0x04000305 RID: 773
			[FieldOffset(16)]
			public ParticleSystem.PlaybackState.Emission m_Emission;

			// Token: 0x04000306 RID: 774
			[FieldOffset(40)]
			public ParticleSystem.PlaybackState.Initial m_Initial;

			// Token: 0x04000307 RID: 775
			[FieldOffset(104)]
			public ParticleSystem.PlaybackState.Shape m_Shape;

			// Token: 0x04000308 RID: 776
			[FieldOffset(196)]
			public ParticleSystem.PlaybackState.Force m_Force;

			// Token: 0x04000309 RID: 777
			[FieldOffset(260)]
			public ParticleSystem.PlaybackState.Collision m_Collision;

			// Token: 0x0400030A RID: 778
			[FieldOffset(324)]
			public ParticleSystem.PlaybackState.Noise m_Noise;

			// Token: 0x0400030B RID: 779
			[FieldOffset(328)]
			public ParticleSystem.PlaybackState.Lights m_Lights;

			// Token: 0x0400030C RID: 780
			[FieldOffset(348)]
			public ParticleSystem.PlaybackState.Trail m_Trail;

			// Token: 0x02000087 RID: 135
			[StructLayout(2)]
			public struct Seed
			{
				// Token: 0x060002B3 RID: 691 RVA: 0x0000C678 File Offset: 0x0000A878
				// Note: this type is marked as 'beforefieldinit'.
				static Seed()
				{
					Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "Seed");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed>.NativeClassPtr);
					ParticleSystem.PlaybackState.Seed.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed>.NativeClassPtr, "x");
					ParticleSystem.PlaybackState.Seed.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed>.NativeClassPtr, "y");
					ParticleSystem.PlaybackState.Seed.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed>.NativeClassPtr, "z");
					ParticleSystem.PlaybackState.Seed.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed>.NativeClassPtr, "w");
				}

				// Token: 0x060002B4 RID: 692 RVA: 0x00002BB9 File Offset: 0x00000DB9
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed>.NativeClassPtr, ref this));
				}

				// Token: 0x04000349 RID: 841
				private static readonly IntPtr NativeFieldInfoPtr_x;

				// Token: 0x0400034A RID: 842
				private static readonly IntPtr NativeFieldInfoPtr_y;

				// Token: 0x0400034B RID: 843
				private static readonly IntPtr NativeFieldInfoPtr_z;

				// Token: 0x0400034C RID: 844
				private static readonly IntPtr NativeFieldInfoPtr_w;

				// Token: 0x0400034D RID: 845
				[FieldOffset(0)]
				public uint x;

				// Token: 0x0400034E RID: 846
				[FieldOffset(4)]
				public uint y;

				// Token: 0x0400034F RID: 847
				[FieldOffset(8)]
				public uint z;

				// Token: 0x04000350 RID: 848
				[FieldOffset(12)]
				public uint w;
			}

			// Token: 0x02000088 RID: 136
			[StructLayout(2)]
			public struct Seed4
			{
				// Token: 0x060002B5 RID: 693 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
				// Note: this type is marked as 'beforefieldinit'.
				static Seed4()
				{
					Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "Seed4");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed4>.NativeClassPtr);
					ParticleSystem.PlaybackState.Seed4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed4>.NativeClassPtr, "x");
					ParticleSystem.PlaybackState.Seed4.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed4>.NativeClassPtr, "y");
					ParticleSystem.PlaybackState.Seed4.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed4>.NativeClassPtr, "z");
					ParticleSystem.PlaybackState.Seed4.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed4>.NativeClassPtr, "w");
				}

				// Token: 0x060002B6 RID: 694 RVA: 0x00002BCB File Offset: 0x00000DCB
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Seed4>.NativeClassPtr, ref this));
				}

				// Token: 0x04000351 RID: 849
				private static readonly IntPtr NativeFieldInfoPtr_x;

				// Token: 0x04000352 RID: 850
				private static readonly IntPtr NativeFieldInfoPtr_y;

				// Token: 0x04000353 RID: 851
				private static readonly IntPtr NativeFieldInfoPtr_z;

				// Token: 0x04000354 RID: 852
				private static readonly IntPtr NativeFieldInfoPtr_w;

				// Token: 0x04000355 RID: 853
				[FieldOffset(0)]
				public ParticleSystem.PlaybackState.Seed x;

				// Token: 0x04000356 RID: 854
				[FieldOffset(16)]
				public ParticleSystem.PlaybackState.Seed y;

				// Token: 0x04000357 RID: 855
				[FieldOffset(32)]
				public ParticleSystem.PlaybackState.Seed z;

				// Token: 0x04000358 RID: 856
				[FieldOffset(48)]
				public ParticleSystem.PlaybackState.Seed w;
			}

			// Token: 0x02000089 RID: 137
			[StructLayout(2)]
			public struct Emission
			{
				// Token: 0x060002B7 RID: 695 RVA: 0x0000C770 File Offset: 0x0000A970
				// Note: this type is marked as 'beforefieldinit'.
				static Emission()
				{
					Il2CppClassPointerStore<ParticleSystem.PlaybackState.Emission>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "Emission");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Emission>.NativeClassPtr);
					ParticleSystem.PlaybackState.Emission.NativeFieldInfoPtr_m_ParticleSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Emission>.NativeClassPtr, "m_ParticleSpacing");
					ParticleSystem.PlaybackState.Emission.NativeFieldInfoPtr_m_ToEmitAccumulator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Emission>.NativeClassPtr, "m_ToEmitAccumulator");
					ParticleSystem.PlaybackState.Emission.NativeFieldInfoPtr_m_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Emission>.NativeClassPtr, "m_Random");
				}

				// Token: 0x060002B8 RID: 696 RVA: 0x00002BDD File Offset: 0x00000DDD
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Emission>.NativeClassPtr, ref this));
				}

				// Token: 0x04000359 RID: 857
				private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSpacing;

				// Token: 0x0400035A RID: 858
				private static readonly IntPtr NativeFieldInfoPtr_m_ToEmitAccumulator;

				// Token: 0x0400035B RID: 859
				private static readonly IntPtr NativeFieldInfoPtr_m_Random;

				// Token: 0x0400035C RID: 860
				[FieldOffset(0)]
				public float m_ParticleSpacing;

				// Token: 0x0400035D RID: 861
				[FieldOffset(4)]
				public float m_ToEmitAccumulator;

				// Token: 0x0400035E RID: 862
				[FieldOffset(8)]
				public ParticleSystem.PlaybackState.Seed m_Random;
			}

			// Token: 0x0200008A RID: 138
			[StructLayout(2)]
			public struct Initial
			{
				// Token: 0x060002B9 RID: 697 RVA: 0x00002BEF File Offset: 0x00000DEF
				// Note: this type is marked as 'beforefieldinit'.
				static Initial()
				{
					Il2CppClassPointerStore<ParticleSystem.PlaybackState.Initial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "Initial");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Initial>.NativeClassPtr);
					ParticleSystem.PlaybackState.Initial.NativeFieldInfoPtr_m_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Initial>.NativeClassPtr, "m_Random");
				}

				// Token: 0x060002BA RID: 698 RVA: 0x00002C23 File Offset: 0x00000E23
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Initial>.NativeClassPtr, ref this));
				}

				// Token: 0x0400035F RID: 863
				private static readonly IntPtr NativeFieldInfoPtr_m_Random;

				// Token: 0x04000360 RID: 864
				[FieldOffset(0)]
				public ParticleSystem.PlaybackState.Seed4 m_Random;
			}

			// Token: 0x0200008B RID: 139
			[StructLayout(2)]
			public struct Shape
			{
				// Token: 0x060002BB RID: 699 RVA: 0x0000C7D8 File Offset: 0x0000A9D8
				// Note: this type is marked as 'beforefieldinit'.
				static Shape()
				{
					Il2CppClassPointerStore<ParticleSystem.PlaybackState.Shape>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "Shape");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Shape>.NativeClassPtr);
					ParticleSystem.PlaybackState.Shape.NativeFieldInfoPtr_m_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Shape>.NativeClassPtr, "m_Random");
					ParticleSystem.PlaybackState.Shape.NativeFieldInfoPtr_m_RadiusTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Shape>.NativeClassPtr, "m_RadiusTimer");
					ParticleSystem.PlaybackState.Shape.NativeFieldInfoPtr_m_RadiusTimerPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Shape>.NativeClassPtr, "m_RadiusTimerPrev");
					ParticleSystem.PlaybackState.Shape.NativeFieldInfoPtr_m_ArcTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Shape>.NativeClassPtr, "m_ArcTimer");
					ParticleSystem.PlaybackState.Shape.NativeFieldInfoPtr_m_ArcTimerPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Shape>.NativeClassPtr, "m_ArcTimerPrev");
					ParticleSystem.PlaybackState.Shape.NativeFieldInfoPtr_m_MeshSpawnTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Shape>.NativeClassPtr, "m_MeshSpawnTimer");
					ParticleSystem.PlaybackState.Shape.NativeFieldInfoPtr_m_MeshSpawnTimerPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Shape>.NativeClassPtr, "m_MeshSpawnTimerPrev");
					ParticleSystem.PlaybackState.Shape.NativeFieldInfoPtr_m_OrderedMeshVertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Shape>.NativeClassPtr, "m_OrderedMeshVertexIndex");
				}

				// Token: 0x060002BC RID: 700 RVA: 0x00002C35 File Offset: 0x00000E35
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Shape>.NativeClassPtr, ref this));
				}

				// Token: 0x04000361 RID: 865
				private static readonly IntPtr NativeFieldInfoPtr_m_Random;

				// Token: 0x04000362 RID: 866
				private static readonly IntPtr NativeFieldInfoPtr_m_RadiusTimer;

				// Token: 0x04000363 RID: 867
				private static readonly IntPtr NativeFieldInfoPtr_m_RadiusTimerPrev;

				// Token: 0x04000364 RID: 868
				private static readonly IntPtr NativeFieldInfoPtr_m_ArcTimer;

				// Token: 0x04000365 RID: 869
				private static readonly IntPtr NativeFieldInfoPtr_m_ArcTimerPrev;

				// Token: 0x04000366 RID: 870
				private static readonly IntPtr NativeFieldInfoPtr_m_MeshSpawnTimer;

				// Token: 0x04000367 RID: 871
				private static readonly IntPtr NativeFieldInfoPtr_m_MeshSpawnTimerPrev;

				// Token: 0x04000368 RID: 872
				private static readonly IntPtr NativeFieldInfoPtr_m_OrderedMeshVertexIndex;

				// Token: 0x04000369 RID: 873
				[FieldOffset(0)]
				public ParticleSystem.PlaybackState.Seed4 m_Random;

				// Token: 0x0400036A RID: 874
				[FieldOffset(64)]
				public float m_RadiusTimer;

				// Token: 0x0400036B RID: 875
				[FieldOffset(68)]
				public float m_RadiusTimerPrev;

				// Token: 0x0400036C RID: 876
				[FieldOffset(72)]
				public float m_ArcTimer;

				// Token: 0x0400036D RID: 877
				[FieldOffset(76)]
				public float m_ArcTimerPrev;

				// Token: 0x0400036E RID: 878
				[FieldOffset(80)]
				public float m_MeshSpawnTimer;

				// Token: 0x0400036F RID: 879
				[FieldOffset(84)]
				public float m_MeshSpawnTimerPrev;

				// Token: 0x04000370 RID: 880
				[FieldOffset(88)]
				public int m_OrderedMeshVertexIndex;
			}

			// Token: 0x0200008C RID: 140
			[StructLayout(2)]
			public struct Force
			{
				// Token: 0x060002BD RID: 701 RVA: 0x00002C47 File Offset: 0x00000E47
				// Note: this type is marked as 'beforefieldinit'.
				static Force()
				{
					Il2CppClassPointerStore<ParticleSystem.PlaybackState.Force>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "Force");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Force>.NativeClassPtr);
					ParticleSystem.PlaybackState.Force.NativeFieldInfoPtr_m_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Force>.NativeClassPtr, "m_Random");
				}

				// Token: 0x060002BE RID: 702 RVA: 0x00002C7B File Offset: 0x00000E7B
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Force>.NativeClassPtr, ref this));
				}

				// Token: 0x04000371 RID: 881
				private static readonly IntPtr NativeFieldInfoPtr_m_Random;

				// Token: 0x04000372 RID: 882
				[FieldOffset(0)]
				public ParticleSystem.PlaybackState.Seed4 m_Random;
			}

			// Token: 0x0200008D RID: 141
			[StructLayout(2)]
			public struct Collision
			{
				// Token: 0x060002BF RID: 703 RVA: 0x00002C8D File Offset: 0x00000E8D
				// Note: this type is marked as 'beforefieldinit'.
				static Collision()
				{
					Il2CppClassPointerStore<ParticleSystem.PlaybackState.Collision>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "Collision");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Collision>.NativeClassPtr);
					ParticleSystem.PlaybackState.Collision.NativeFieldInfoPtr_m_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Collision>.NativeClassPtr, "m_Random");
				}

				// Token: 0x060002C0 RID: 704 RVA: 0x00002CC1 File Offset: 0x00000EC1
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Collision>.NativeClassPtr, ref this));
				}

				// Token: 0x04000373 RID: 883
				private static readonly IntPtr NativeFieldInfoPtr_m_Random;

				// Token: 0x04000374 RID: 884
				[FieldOffset(0)]
				public ParticleSystem.PlaybackState.Seed4 m_Random;
			}

			// Token: 0x0200008E RID: 142
			[StructLayout(2)]
			public struct Noise
			{
				// Token: 0x060002C1 RID: 705 RVA: 0x00002CD3 File Offset: 0x00000ED3
				// Note: this type is marked as 'beforefieldinit'.
				static Noise()
				{
					Il2CppClassPointerStore<ParticleSystem.PlaybackState.Noise>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "Noise");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Noise>.NativeClassPtr);
					ParticleSystem.PlaybackState.Noise.NativeFieldInfoPtr_m_ScrollOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Noise>.NativeClassPtr, "m_ScrollOffset");
				}

				// Token: 0x060002C2 RID: 706 RVA: 0x00002D07 File Offset: 0x00000F07
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Noise>.NativeClassPtr, ref this));
				}

				// Token: 0x04000375 RID: 885
				private static readonly IntPtr NativeFieldInfoPtr_m_ScrollOffset;

				// Token: 0x04000376 RID: 886
				[FieldOffset(0)]
				public float m_ScrollOffset;
			}

			// Token: 0x0200008F RID: 143
			[StructLayout(2)]
			public struct Lights
			{
				// Token: 0x060002C3 RID: 707 RVA: 0x0000C8A4 File Offset: 0x0000AAA4
				// Note: this type is marked as 'beforefieldinit'.
				static Lights()
				{
					Il2CppClassPointerStore<ParticleSystem.PlaybackState.Lights>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "Lights");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Lights>.NativeClassPtr);
					ParticleSystem.PlaybackState.Lights.NativeFieldInfoPtr_m_Random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Lights>.NativeClassPtr, "m_Random");
					ParticleSystem.PlaybackState.Lights.NativeFieldInfoPtr_m_ParticleEmissionCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Lights>.NativeClassPtr, "m_ParticleEmissionCounter");
				}

				// Token: 0x060002C4 RID: 708 RVA: 0x00002D19 File Offset: 0x00000F19
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Lights>.NativeClassPtr, ref this));
				}

				// Token: 0x04000377 RID: 887
				private static readonly IntPtr NativeFieldInfoPtr_m_Random;

				// Token: 0x04000378 RID: 888
				private static readonly IntPtr NativeFieldInfoPtr_m_ParticleEmissionCounter;

				// Token: 0x04000379 RID: 889
				[FieldOffset(0)]
				public ParticleSystem.PlaybackState.Seed m_Random;

				// Token: 0x0400037A RID: 890
				[FieldOffset(16)]
				public float m_ParticleEmissionCounter;
			}

			// Token: 0x02000090 RID: 144
			[StructLayout(2)]
			public struct Trail
			{
				// Token: 0x060002C5 RID: 709 RVA: 0x00002D2B File Offset: 0x00000F2B
				// Note: this type is marked as 'beforefieldinit'.
				static Trail()
				{
					Il2CppClassPointerStore<ParticleSystem.PlaybackState.Trail>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem.PlaybackState>.NativeClassPtr, "Trail");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Trail>.NativeClassPtr);
					ParticleSystem.PlaybackState.Trail.NativeFieldInfoPtr_m_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Trail>.NativeClassPtr, "m_Timer");
				}

				// Token: 0x060002C6 RID: 710 RVA: 0x00002D5F File Offset: 0x00000F5F
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystem.PlaybackState.Trail>.NativeClassPtr, ref this));
				}

				// Token: 0x0400037B RID: 891
				private static readonly IntPtr NativeFieldInfoPtr_m_Timer;

				// Token: 0x0400037C RID: 892
				[FieldOffset(0)]
				public float m_Timer;
			}
		}

		// Token: 0x0200004A RID: 74
		public sealed class Trails : ValueType
		{
			// Token: 0x060001E6 RID: 486 RVA: 0x0000B55C File Offset: 0x0000975C
			// Note: this type is marked as 'beforefieldinit'.
			static Trails()
			{
				Il2CppClassPointerStore<ParticleSystem.Trails>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "Trails");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.Trails>.NativeClassPtr);
				ParticleSystem.Trails.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Trails>.NativeClassPtr, "positions");
				ParticleSystem.Trails.NativeFieldInfoPtr_frontPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Trails>.NativeClassPtr, "frontPositions");
				ParticleSystem.Trails.NativeFieldInfoPtr_backPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Trails>.NativeClassPtr, "backPositions");
				ParticleSystem.Trails.NativeFieldInfoPtr_positionCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Trails>.NativeClassPtr, "positionCounts");
				ParticleSystem.Trails.NativeFieldInfoPtr_textureOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Trails>.NativeClassPtr, "textureOffsets");
				ParticleSystem.Trails.NativeFieldInfoPtr_maxTrailCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Trails>.NativeClassPtr, "maxTrailCount");
				ParticleSystem.Trails.NativeFieldInfoPtr_maxPositionsPerTrailCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.Trails>.NativeClassPtr, "maxPositionsPerTrailCount");
				ParticleSystem.Trails.NativeMethodInfoPtr_Allocate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.Trails>.NativeClassPtr, 100663540);
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x0000B628 File Offset: 0x00009828
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1221152, RefRangeEnd = 1221154, XrefRangeStart = 1221121, XrefRangeEnd = 1221152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Allocate()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.Trails.NativeMethodInfoPtr_Allocate_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x000026B0 File Offset: 0x000008B0
			public Trails(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001E9 RID: 489 RVA: 0x000026B9 File Offset: 0x000008B9
			public Trails()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.Trails>.NativeClassPtr))
			{
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x060001EA RID: 490 RVA: 0x0000B660 File Offset: 0x00009860
			// (set) Token: 0x060001EB RID: 491 RVA: 0x000026CB File Offset: 0x000008CB
			public unsafe List<Vector4> positions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_positions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector4>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_positions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060001EC RID: 492 RVA: 0x0000B690 File Offset: 0x00009890
			// (set) Token: 0x060001ED RID: 493 RVA: 0x000026EA File Offset: 0x000008EA
			public unsafe List<int> frontPositions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_frontPositions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_frontPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060001EE RID: 494 RVA: 0x0000B6C0 File Offset: 0x000098C0
			// (set) Token: 0x060001EF RID: 495 RVA: 0x00002709 File Offset: 0x00000909
			public unsafe List<int> backPositions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_backPositions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_backPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000B6F0 File Offset: 0x000098F0
			// (set) Token: 0x060001F1 RID: 497 RVA: 0x00002728 File Offset: 0x00000928
			public unsafe List<int> positionCounts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_positionCounts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_positionCounts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000B720 File Offset: 0x00009920
			// (set) Token: 0x060001F3 RID: 499 RVA: 0x00002747 File Offset: 0x00000947
			public unsafe List<float> textureOffsets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_textureOffsets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_textureOffsets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000B750 File Offset: 0x00009950
			// (set) Token: 0x060001F5 RID: 501 RVA: 0x00002766 File Offset: 0x00000966
			public unsafe int maxTrailCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_maxTrailCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_maxTrailCount)) = value;
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000B778 File Offset: 0x00009978
			// (set) Token: 0x060001F7 RID: 503 RVA: 0x00002781 File Offset: 0x00000981
			public unsafe int maxPositionsPerTrailCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_maxPositionsPerTrailCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.Trails.NativeFieldInfoPtr_maxPositionsPerTrailCount)) = value;
				}
			}

			// Token: 0x0400030D RID: 781
			private static readonly IntPtr NativeFieldInfoPtr_positions;

			// Token: 0x0400030E RID: 782
			private static readonly IntPtr NativeFieldInfoPtr_frontPositions;

			// Token: 0x0400030F RID: 783
			private static readonly IntPtr NativeFieldInfoPtr_backPositions;

			// Token: 0x04000310 RID: 784
			private static readonly IntPtr NativeFieldInfoPtr_positionCounts;

			// Token: 0x04000311 RID: 785
			private static readonly IntPtr NativeFieldInfoPtr_textureOffsets;

			// Token: 0x04000312 RID: 786
			private static readonly IntPtr NativeFieldInfoPtr_maxTrailCount;

			// Token: 0x04000313 RID: 787
			private static readonly IntPtr NativeFieldInfoPtr_maxPositionsPerTrailCount;

			// Token: 0x04000314 RID: 788
			private static readonly IntPtr NativeMethodInfoPtr_Allocate_Internal_Void_0;
		}

		// Token: 0x0200004B RID: 75
		public sealed class VelocityOverLifetimeModule : ValueType
		{
			// Token: 0x060001F8 RID: 504 RVA: 0x0000B7A0 File Offset: 0x000099A0
			// Note: this type is marked as 'beforefieldinit'.
			static VelocityOverLifetimeModule()
			{
				Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "VelocityOverLifetimeModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr);
				ParticleSystem.VelocityOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.VelocityOverLifetimeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr, 100663541);
			}

			// Token: 0x060001F9 RID: 505 RVA: 0x0000B7F4 File Offset: 0x000099F4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VelocityOverLifetimeModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.VelocityOverLifetimeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060001FA RID: 506 RVA: 0x0000279C File Offset: 0x0000099C
			public VelocityOverLifetimeModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060001FB RID: 507 RVA: 0x000027A5 File Offset: 0x000009A5
			public VelocityOverLifetimeModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.VelocityOverLifetimeModule>.NativeClassPtr))
			{
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060001FC RID: 508 RVA: 0x0000B844 File Offset: 0x00009A44
			// (set) Token: 0x060001FD RID: 509 RVA: 0x000027B7 File Offset: 0x000009B7
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.VelocityOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.VelocityOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000315 RID: 789
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000316 RID: 790
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x0200004C RID: 76
		public sealed class LimitVelocityOverLifetimeModule : ValueType
		{
			// Token: 0x060001FE RID: 510 RVA: 0x0000B874 File Offset: 0x00009A74
			// Note: this type is marked as 'beforefieldinit'.
			static LimitVelocityOverLifetimeModule()
			{
				Il2CppClassPointerStore<ParticleSystem.LimitVelocityOverLifetimeModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "LimitVelocityOverLifetimeModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.LimitVelocityOverLifetimeModule>.NativeClassPtr);
				ParticleSystem.LimitVelocityOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.LimitVelocityOverLifetimeModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.LimitVelocityOverLifetimeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.LimitVelocityOverLifetimeModule>.NativeClassPtr, 100663542);
			}

			// Token: 0x060001FF RID: 511 RVA: 0x0000B8C8 File Offset: 0x00009AC8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LimitVelocityOverLifetimeModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.LimitVelocityOverLifetimeModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.LimitVelocityOverLifetimeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000200 RID: 512 RVA: 0x000027D6 File Offset: 0x000009D6
			public LimitVelocityOverLifetimeModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000201 RID: 513 RVA: 0x000027DF File Offset: 0x000009DF
			public LimitVelocityOverLifetimeModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.LimitVelocityOverLifetimeModule>.NativeClassPtr))
			{
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x06000202 RID: 514 RVA: 0x0000B918 File Offset: 0x00009B18
			// (set) Token: 0x06000203 RID: 515 RVA: 0x000027F1 File Offset: 0x000009F1
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.LimitVelocityOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.LimitVelocityOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000317 RID: 791
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000318 RID: 792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x0200004D RID: 77
		public sealed class InheritVelocityModule : ValueType
		{
			// Token: 0x06000204 RID: 516 RVA: 0x0000B948 File Offset: 0x00009B48
			// Note: this type is marked as 'beforefieldinit'.
			static InheritVelocityModule()
			{
				Il2CppClassPointerStore<ParticleSystem.InheritVelocityModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "InheritVelocityModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.InheritVelocityModule>.NativeClassPtr);
				ParticleSystem.InheritVelocityModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.InheritVelocityModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.InheritVelocityModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.InheritVelocityModule>.NativeClassPtr, 100663543);
			}

			// Token: 0x06000205 RID: 517 RVA: 0x0000B99C File Offset: 0x00009B9C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InheritVelocityModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.InheritVelocityModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.InheritVelocityModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000206 RID: 518 RVA: 0x00002810 File Offset: 0x00000A10
			public InheritVelocityModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000207 RID: 519 RVA: 0x00002819 File Offset: 0x00000A19
			public InheritVelocityModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.InheritVelocityModule>.NativeClassPtr))
			{
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x06000208 RID: 520 RVA: 0x0000B9EC File Offset: 0x00009BEC
			// (set) Token: 0x06000209 RID: 521 RVA: 0x0000282B File Offset: 0x00000A2B
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.InheritVelocityModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.InheritVelocityModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000319 RID: 793
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x0400031A RID: 794
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x0200004E RID: 78
		public sealed class LifetimeByEmitterSpeedModule : ValueType
		{
			// Token: 0x0600020A RID: 522 RVA: 0x0000BA1C File Offset: 0x00009C1C
			// Note: this type is marked as 'beforefieldinit'.
			static LifetimeByEmitterSpeedModule()
			{
				Il2CppClassPointerStore<ParticleSystem.LifetimeByEmitterSpeedModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "LifetimeByEmitterSpeedModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.LifetimeByEmitterSpeedModule>.NativeClassPtr);
				ParticleSystem.LifetimeByEmitterSpeedModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.LifetimeByEmitterSpeedModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.LifetimeByEmitterSpeedModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.LifetimeByEmitterSpeedModule>.NativeClassPtr, 100663544);
			}

			// Token: 0x0600020B RID: 523 RVA: 0x0000BA70 File Offset: 0x00009C70
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LifetimeByEmitterSpeedModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.LifetimeByEmitterSpeedModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.LifetimeByEmitterSpeedModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600020C RID: 524 RVA: 0x0000284A File Offset: 0x00000A4A
			public LifetimeByEmitterSpeedModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600020D RID: 525 RVA: 0x00002853 File Offset: 0x00000A53
			public LifetimeByEmitterSpeedModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.LifetimeByEmitterSpeedModule>.NativeClassPtr))
			{
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x0600020E RID: 526 RVA: 0x0000BAC0 File Offset: 0x00009CC0
			// (set) Token: 0x0600020F RID: 527 RVA: 0x00002865 File Offset: 0x00000A65
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.LifetimeByEmitterSpeedModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.LifetimeByEmitterSpeedModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400031B RID: 795
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x0400031C RID: 796
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x0200004F RID: 79
		public sealed class ForceOverLifetimeModule : ValueType
		{
			// Token: 0x06000210 RID: 528 RVA: 0x0000BAF0 File Offset: 0x00009CF0
			// Note: this type is marked as 'beforefieldinit'.
			static ForceOverLifetimeModule()
			{
				Il2CppClassPointerStore<ParticleSystem.ForceOverLifetimeModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "ForceOverLifetimeModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.ForceOverLifetimeModule>.NativeClassPtr);
				ParticleSystem.ForceOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.ForceOverLifetimeModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.ForceOverLifetimeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.ForceOverLifetimeModule>.NativeClassPtr, 100663545);
			}

			// Token: 0x06000211 RID: 529 RVA: 0x0000BB44 File Offset: 0x00009D44
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ForceOverLifetimeModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.ForceOverLifetimeModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.ForceOverLifetimeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000212 RID: 530 RVA: 0x00002884 File Offset: 0x00000A84
			public ForceOverLifetimeModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000213 RID: 531 RVA: 0x0000288D File Offset: 0x00000A8D
			public ForceOverLifetimeModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.ForceOverLifetimeModule>.NativeClassPtr))
			{
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x06000214 RID: 532 RVA: 0x0000BB94 File Offset: 0x00009D94
			// (set) Token: 0x06000215 RID: 533 RVA: 0x0000289F File Offset: 0x00000A9F
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.ForceOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.ForceOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400031D RID: 797
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x0400031E RID: 798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000050 RID: 80
		public sealed class ColorOverLifetimeModule : ValueType
		{
			// Token: 0x06000216 RID: 534 RVA: 0x0000BBC4 File Offset: 0x00009DC4
			// Note: this type is marked as 'beforefieldinit'.
			static ColorOverLifetimeModule()
			{
				Il2CppClassPointerStore<ParticleSystem.ColorOverLifetimeModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "ColorOverLifetimeModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.ColorOverLifetimeModule>.NativeClassPtr);
				ParticleSystem.ColorOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.ColorOverLifetimeModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.ColorOverLifetimeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.ColorOverLifetimeModule>.NativeClassPtr, 100663546);
			}

			// Token: 0x06000217 RID: 535 RVA: 0x0000BC18 File Offset: 0x00009E18
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorOverLifetimeModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.ColorOverLifetimeModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.ColorOverLifetimeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000218 RID: 536 RVA: 0x000028BE File Offset: 0x00000ABE
			public ColorOverLifetimeModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000219 RID: 537 RVA: 0x000028C7 File Offset: 0x00000AC7
			public ColorOverLifetimeModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.ColorOverLifetimeModule>.NativeClassPtr))
			{
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x0600021A RID: 538 RVA: 0x0000BC68 File Offset: 0x00009E68
			// (set) Token: 0x0600021B RID: 539 RVA: 0x000028D9 File Offset: 0x00000AD9
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.ColorOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.ColorOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400031F RID: 799
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000320 RID: 800
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000051 RID: 81
		public sealed class ColorBySpeedModule : ValueType
		{
			// Token: 0x0600021C RID: 540 RVA: 0x0000BC98 File Offset: 0x00009E98
			// Note: this type is marked as 'beforefieldinit'.
			static ColorBySpeedModule()
			{
				Il2CppClassPointerStore<ParticleSystem.ColorBySpeedModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "ColorBySpeedModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.ColorBySpeedModule>.NativeClassPtr);
				ParticleSystem.ColorBySpeedModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.ColorBySpeedModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.ColorBySpeedModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.ColorBySpeedModule>.NativeClassPtr, 100663547);
			}

			// Token: 0x0600021D RID: 541 RVA: 0x0000BCEC File Offset: 0x00009EEC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorBySpeedModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.ColorBySpeedModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.ColorBySpeedModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600021E RID: 542 RVA: 0x000028F8 File Offset: 0x00000AF8
			public ColorBySpeedModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600021F RID: 543 RVA: 0x00002901 File Offset: 0x00000B01
			public ColorBySpeedModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.ColorBySpeedModule>.NativeClassPtr))
			{
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x06000220 RID: 544 RVA: 0x0000BD3C File Offset: 0x00009F3C
			// (set) Token: 0x06000221 RID: 545 RVA: 0x00002913 File Offset: 0x00000B13
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.ColorBySpeedModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.ColorBySpeedModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000321 RID: 801
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000322 RID: 802
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000052 RID: 82
		public sealed class SizeOverLifetimeModule : ValueType
		{
			// Token: 0x06000222 RID: 546 RVA: 0x0000BD6C File Offset: 0x00009F6C
			// Note: this type is marked as 'beforefieldinit'.
			static SizeOverLifetimeModule()
			{
				Il2CppClassPointerStore<ParticleSystem.SizeOverLifetimeModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "SizeOverLifetimeModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.SizeOverLifetimeModule>.NativeClassPtr);
				ParticleSystem.SizeOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.SizeOverLifetimeModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.SizeOverLifetimeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.SizeOverLifetimeModule>.NativeClassPtr, 100663548);
			}

			// Token: 0x06000223 RID: 547 RVA: 0x0000BDC0 File Offset: 0x00009FC0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SizeOverLifetimeModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.SizeOverLifetimeModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.SizeOverLifetimeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000224 RID: 548 RVA: 0x00002932 File Offset: 0x00000B32
			public SizeOverLifetimeModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000225 RID: 549 RVA: 0x0000293B File Offset: 0x00000B3B
			public SizeOverLifetimeModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.SizeOverLifetimeModule>.NativeClassPtr))
			{
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x06000226 RID: 550 RVA: 0x0000BE10 File Offset: 0x0000A010
			// (set) Token: 0x06000227 RID: 551 RVA: 0x0000294D File Offset: 0x00000B4D
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.SizeOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.SizeOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000323 RID: 803
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000324 RID: 804
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000053 RID: 83
		public sealed class SizeBySpeedModule : ValueType
		{
			// Token: 0x06000228 RID: 552 RVA: 0x0000BE40 File Offset: 0x0000A040
			// Note: this type is marked as 'beforefieldinit'.
			static SizeBySpeedModule()
			{
				Il2CppClassPointerStore<ParticleSystem.SizeBySpeedModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "SizeBySpeedModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.SizeBySpeedModule>.NativeClassPtr);
				ParticleSystem.SizeBySpeedModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.SizeBySpeedModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.SizeBySpeedModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.SizeBySpeedModule>.NativeClassPtr, 100663549);
			}

			// Token: 0x06000229 RID: 553 RVA: 0x0000BE94 File Offset: 0x0000A094
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SizeBySpeedModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.SizeBySpeedModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.SizeBySpeedModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600022A RID: 554 RVA: 0x0000296C File Offset: 0x00000B6C
			public SizeBySpeedModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600022B RID: 555 RVA: 0x00002975 File Offset: 0x00000B75
			public SizeBySpeedModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.SizeBySpeedModule>.NativeClassPtr))
			{
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x0600022C RID: 556 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
			// (set) Token: 0x0600022D RID: 557 RVA: 0x00002987 File Offset: 0x00000B87
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.SizeBySpeedModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.SizeBySpeedModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000325 RID: 805
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000326 RID: 806
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000054 RID: 84
		public sealed class RotationOverLifetimeModule : ValueType
		{
			// Token: 0x0600022E RID: 558 RVA: 0x0000BF14 File Offset: 0x0000A114
			// Note: this type is marked as 'beforefieldinit'.
			static RotationOverLifetimeModule()
			{
				Il2CppClassPointerStore<ParticleSystem.RotationOverLifetimeModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "RotationOverLifetimeModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.RotationOverLifetimeModule>.NativeClassPtr);
				ParticleSystem.RotationOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.RotationOverLifetimeModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.RotationOverLifetimeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.RotationOverLifetimeModule>.NativeClassPtr, 100663550);
			}

			// Token: 0x0600022F RID: 559 RVA: 0x0000BF68 File Offset: 0x0000A168
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RotationOverLifetimeModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.RotationOverLifetimeModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.RotationOverLifetimeModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000230 RID: 560 RVA: 0x000029A6 File Offset: 0x00000BA6
			public RotationOverLifetimeModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000231 RID: 561 RVA: 0x000029AF File Offset: 0x00000BAF
			public RotationOverLifetimeModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.RotationOverLifetimeModule>.NativeClassPtr))
			{
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x06000232 RID: 562 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
			// (set) Token: 0x06000233 RID: 563 RVA: 0x000029C1 File Offset: 0x00000BC1
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.RotationOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.RotationOverLifetimeModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000327 RID: 807
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000328 RID: 808
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000055 RID: 85
		public sealed class RotationBySpeedModule : ValueType
		{
			// Token: 0x06000234 RID: 564 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
			// Note: this type is marked as 'beforefieldinit'.
			static RotationBySpeedModule()
			{
				Il2CppClassPointerStore<ParticleSystem.RotationBySpeedModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "RotationBySpeedModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.RotationBySpeedModule>.NativeClassPtr);
				ParticleSystem.RotationBySpeedModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.RotationBySpeedModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.RotationBySpeedModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.RotationBySpeedModule>.NativeClassPtr, 100663551);
			}

			// Token: 0x06000235 RID: 565 RVA: 0x0000C03C File Offset: 0x0000A23C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RotationBySpeedModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.RotationBySpeedModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.RotationBySpeedModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000236 RID: 566 RVA: 0x000029E0 File Offset: 0x00000BE0
			public RotationBySpeedModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000237 RID: 567 RVA: 0x000029E9 File Offset: 0x00000BE9
			public RotationBySpeedModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.RotationBySpeedModule>.NativeClassPtr))
			{
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x06000238 RID: 568 RVA: 0x0000C08C File Offset: 0x0000A28C
			// (set) Token: 0x06000239 RID: 569 RVA: 0x000029FB File Offset: 0x00000BFB
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.RotationBySpeedModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.RotationBySpeedModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000329 RID: 809
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x0400032A RID: 810
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000056 RID: 86
		public sealed class ExternalForcesModule : ValueType
		{
			// Token: 0x0600023A RID: 570 RVA: 0x0000C0BC File Offset: 0x0000A2BC
			// Note: this type is marked as 'beforefieldinit'.
			static ExternalForcesModule()
			{
				Il2CppClassPointerStore<ParticleSystem.ExternalForcesModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "ExternalForcesModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.ExternalForcesModule>.NativeClassPtr);
				ParticleSystem.ExternalForcesModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.ExternalForcesModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.ExternalForcesModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.ExternalForcesModule>.NativeClassPtr, 100663552);
			}

			// Token: 0x0600023B RID: 571 RVA: 0x0000C110 File Offset: 0x0000A310
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExternalForcesModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.ExternalForcesModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.ExternalForcesModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600023C RID: 572 RVA: 0x00002A1A File Offset: 0x00000C1A
			public ExternalForcesModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600023D RID: 573 RVA: 0x00002A23 File Offset: 0x00000C23
			public ExternalForcesModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.ExternalForcesModule>.NativeClassPtr))
			{
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x0600023E RID: 574 RVA: 0x0000C160 File Offset: 0x0000A360
			// (set) Token: 0x0600023F RID: 575 RVA: 0x00002A35 File Offset: 0x00000C35
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.ExternalForcesModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.ExternalForcesModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400032B RID: 811
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x0400032C RID: 812
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000057 RID: 87
		public sealed class NoiseModule : ValueType
		{
			// Token: 0x06000240 RID: 576 RVA: 0x0000C190 File Offset: 0x0000A390
			// Note: this type is marked as 'beforefieldinit'.
			static NoiseModule()
			{
				Il2CppClassPointerStore<ParticleSystem.NoiseModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "NoiseModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.NoiseModule>.NativeClassPtr);
				ParticleSystem.NoiseModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.NoiseModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.NoiseModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.NoiseModule>.NativeClassPtr, 100663553);
			}

			// Token: 0x06000241 RID: 577 RVA: 0x0000C1E4 File Offset: 0x0000A3E4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NoiseModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.NoiseModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.NoiseModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000242 RID: 578 RVA: 0x00002A54 File Offset: 0x00000C54
			public NoiseModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000243 RID: 579 RVA: 0x00002A5D File Offset: 0x00000C5D
			public NoiseModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.NoiseModule>.NativeClassPtr))
			{
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000244 RID: 580 RVA: 0x0000C234 File Offset: 0x0000A434
			// (set) Token: 0x06000245 RID: 581 RVA: 0x00002A6F File Offset: 0x00000C6F
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.NoiseModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.NoiseModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400032D RID: 813
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x0400032E RID: 814
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000058 RID: 88
		public sealed class LightsModule : ValueType
		{
			// Token: 0x06000246 RID: 582 RVA: 0x0000C264 File Offset: 0x0000A464
			// Note: this type is marked as 'beforefieldinit'.
			static LightsModule()
			{
				Il2CppClassPointerStore<ParticleSystem.LightsModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "LightsModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.LightsModule>.NativeClassPtr);
				ParticleSystem.LightsModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.LightsModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.LightsModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.LightsModule>.NativeClassPtr, 100663554);
			}

			// Token: 0x06000247 RID: 583 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LightsModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.LightsModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.LightsModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000248 RID: 584 RVA: 0x00002A8E File Offset: 0x00000C8E
			public LightsModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000249 RID: 585 RVA: 0x00002A97 File Offset: 0x00000C97
			public LightsModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.LightsModule>.NativeClassPtr))
			{
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x0600024A RID: 586 RVA: 0x0000C308 File Offset: 0x0000A508
			// (set) Token: 0x0600024B RID: 587 RVA: 0x00002AA9 File Offset: 0x00000CA9
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.LightsModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.LightsModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400032F RID: 815
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000330 RID: 816
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x02000059 RID: 89
		public sealed class TrailModule : ValueType
		{
			// Token: 0x0600024C RID: 588 RVA: 0x0000C338 File Offset: 0x0000A538
			// Note: this type is marked as 'beforefieldinit'.
			static TrailModule()
			{
				Il2CppClassPointerStore<ParticleSystem.TrailModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "TrailModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.TrailModule>.NativeClassPtr);
				ParticleSystem.TrailModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.TrailModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.TrailModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.TrailModule>.NativeClassPtr, 100663555);
			}

			// Token: 0x0600024D RID: 589 RVA: 0x0000C38C File Offset: 0x0000A58C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TrailModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.TrailModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.TrailModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600024E RID: 590 RVA: 0x00002AC8 File Offset: 0x00000CC8
			public TrailModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600024F RID: 591 RVA: 0x00002AD1 File Offset: 0x00000CD1
			public TrailModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.TrailModule>.NativeClassPtr))
			{
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000250 RID: 592 RVA: 0x0000C3DC File Offset: 0x0000A5DC
			// (set) Token: 0x06000251 RID: 593 RVA: 0x00002AE3 File Offset: 0x00000CE3
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.TrailModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.TrailModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000331 RID: 817
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000332 RID: 818
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}

		// Token: 0x0200005A RID: 90
		public sealed class CustomDataModule : ValueType
		{
			// Token: 0x06000252 RID: 594 RVA: 0x0000C40C File Offset: 0x0000A60C
			// Note: this type is marked as 'beforefieldinit'.
			static CustomDataModule()
			{
				Il2CppClassPointerStore<ParticleSystem.CustomDataModule>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSystem>.NativeClassPtr, "CustomDataModule");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystem.CustomDataModule>.NativeClassPtr);
				ParticleSystem.CustomDataModule.NativeFieldInfoPtr_m_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystem.CustomDataModule>.NativeClassPtr, "m_ParticleSystem");
				ParticleSystem.CustomDataModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystem.CustomDataModule>.NativeClassPtr, 100663556);
			}

			// Token: 0x06000253 RID: 595 RVA: 0x0000C460 File Offset: 0x0000A660
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CustomDataModule(ParticleSystem particleSystem)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.CustomDataModule>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(particleSystem);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticleSystem.CustomDataModule.NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000254 RID: 596 RVA: 0x00002B02 File Offset: 0x00000D02
			public CustomDataModule(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000255 RID: 597 RVA: 0x00002B0B File Offset: 0x00000D0B
			public CustomDataModule()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystem.CustomDataModule>.NativeClassPtr))
			{
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000256 RID: 598 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
			// (set) Token: 0x06000257 RID: 599 RVA: 0x00002B1D File Offset: 0x00000D1D
			public unsafe ParticleSystem m_ParticleSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.CustomDataModule.NativeFieldInfoPtr_m_ParticleSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticleSystem.CustomDataModule.NativeFieldInfoPtr_m_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000333 RID: 819
			private static readonly IntPtr NativeFieldInfoPtr_m_ParticleSystem;

			// Token: 0x04000334 RID: 820
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ParticleSystem_0;
		}
	}
}
