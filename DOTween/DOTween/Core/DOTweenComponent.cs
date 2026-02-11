using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace DG.Tweening.Core
{
	// Token: 0x0200004A RID: 74
	public class DOTweenComponent : MonoBehaviour
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x00019FD8 File Offset: 0x000181D8
		// Note: this type is marked as 'beforefieldinit'.
		static DOTweenComponent()
		{
			Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("DOTween.dll", "DG.Tweening.Core", "DOTweenComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr);
			DOTweenComponent.NativeFieldInfoPtr_inspectorUpdater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "inspectorUpdater");
			DOTweenComponent.NativeFieldInfoPtr__unscaledTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "_unscaledTime");
			DOTweenComponent.NativeFieldInfoPtr__unscaledDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "_unscaledDeltaTime");
			DOTweenComponent.NativeFieldInfoPtr__duplicateToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "_duplicateToDestroy");
			DOTweenComponent.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664171);
			DOTweenComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664172);
			DOTweenComponent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664173);
			DOTweenComponent.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664174);
			DOTweenComponent.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664175);
			DOTweenComponent.NativeMethodInfoPtr_ManualUpdate_Internal_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664176);
			DOTweenComponent.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664177);
			DOTweenComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664178);
			DOTweenComponent.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664179);
			DOTweenComponent.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Final_New_IDOTweenInit_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664180);
			DOTweenComponent.NativeMethodInfoPtr_WaitForCompletion_Internal_IEnumerator_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664181);
			DOTweenComponent.NativeMethodInfoPtr_WaitForRewind_Internal_IEnumerator_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664182);
			DOTweenComponent.NativeMethodInfoPtr_WaitForKill_Internal_IEnumerator_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664183);
			DOTweenComponent.NativeMethodInfoPtr_WaitForElapsedLoops_Internal_IEnumerator_Tween_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664184);
			DOTweenComponent.NativeMethodInfoPtr_WaitForPosition_Internal_IEnumerator_Tween_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664185);
			DOTweenComponent.NativeMethodInfoPtr_WaitForStart_Internal_IEnumerator_Tween_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664186);
			DOTweenComponent.NativeMethodInfoPtr_Create_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664187);
			DOTweenComponent.NativeMethodInfoPtr_DestroyInstance_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664188);
			DOTweenComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, 100664189);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0001A1D4 File Offset: 0x000183D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133294, XrefRangeEnd = 1133295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0001A208 File Offset: 0x00018408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133295, XrefRangeEnd = 1133307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0001A23C File Offset: 0x0001843C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133307, XrefRangeEnd = 1133366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0001A270 File Offset: 0x00018470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133366, XrefRangeEnd = 1133383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0001A2A4 File Offset: 0x000184A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133383, XrefRangeEnd = 1133408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0001A2D8 File Offset: 0x000184D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133419, RefRangeEnd = 1133420, XrefRangeStart = 1133408, XrefRangeEnd = 1133419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ManualUpdate(float deltaTime, float unscaledDeltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deltaTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unscaledDeltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_ManualUpdate_Internal_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0001A324 File Offset: 0x00018524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133420, XrefRangeEnd = 1133436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0001A358 File Offset: 0x00018558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133436, XrefRangeEnd = 1133488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001A38C File Offset: 0x0001858C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133488, XrefRangeEnd = 1133492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001A3C0 File Offset: 0x000185C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133492, XrefRangeEnd = 1133496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref tweenersCapacity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sequencesCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_SetCapacity_Public_Virtual_Final_New_IDOTweenInit_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDOTweenInit>(intPtr3) : null;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0001A41C File Offset: 0x0001861C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133501, RefRangeEnd = 1133502, XrefRangeStart = 1133496, XrefRangeEnd = 1133501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForCompletion(Tween t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_WaitForCompletion_Internal_IEnumerator_Tween_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001A46C File Offset: 0x0001866C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133507, RefRangeEnd = 1133508, XrefRangeStart = 1133502, XrefRangeEnd = 1133507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForRewind(Tween t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_WaitForRewind_Internal_IEnumerator_Tween_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001A4BC File Offset: 0x000186BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133513, RefRangeEnd = 1133514, XrefRangeStart = 1133508, XrefRangeEnd = 1133513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForKill(Tween t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_WaitForKill_Internal_IEnumerator_Tween_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0001A50C File Offset: 0x0001870C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133519, RefRangeEnd = 1133520, XrefRangeStart = 1133514, XrefRangeEnd = 1133519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForElapsedLoops(Tween t, int elapsedLoops)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedLoops;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_WaitForElapsedLoops_Internal_IEnumerator_Tween_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0001A56C File Offset: 0x0001876C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133525, RefRangeEnd = 1133526, XrefRangeStart = 1133520, XrefRangeEnd = 1133525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForPosition(Tween t, float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_WaitForPosition_Internal_IEnumerator_Tween_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0001A5CC File Offset: 0x000187CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133531, RefRangeEnd = 1133532, XrefRangeStart = 1133526, XrefRangeEnd = 1133531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForStart(Tween t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_WaitForStart_Internal_IEnumerator_Tween_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0001A61C File Offset: 0x0001881C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133557, RefRangeEnd = 1133558, XrefRangeStart = 1133532, XrefRangeEnd = 1133557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_Create_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0001A644 File Offset: 0x00018844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1133579, RefRangeEnd = 1133580, XrefRangeStart = 1133558, XrefRangeEnd = 1133579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DestroyInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr_DestroyInstance_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0001A66C File Offset: 0x0001886C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DOTweenComponent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000035DF File Offset: 0x000017DF
		public DOTweenComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0001A6A8 File Offset: 0x000188A8
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x000035E8 File Offset: 0x000017E8
		public unsafe int inspectorUpdater
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr_inspectorUpdater);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr_inspectorUpdater)) = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0001A6D0 File Offset: 0x000188D0
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00003603 File Offset: 0x00001803
		public unsafe float _unscaledTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__unscaledTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__unscaledTime)) = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0001A6F8 File Offset: 0x000188F8
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x0000361E File Offset: 0x0000181E
		public unsafe float _unscaledDeltaTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__unscaledDeltaTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__unscaledDeltaTime)) = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0001A720 File Offset: 0x00018920
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00003639 File Offset: 0x00001839
		public unsafe bool _duplicateToDestroy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__duplicateToDestroy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent.NativeFieldInfoPtr__duplicateToDestroy)) = value;
			}
		}

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeFieldInfoPtr_inspectorUpdater;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeFieldInfoPtr__unscaledTime;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeFieldInfoPtr__unscaledDeltaTime;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeFieldInfoPtr__duplicateToDestroy;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_ManualUpdate_Internal_Void_Single_Single_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_SetCapacity_Public_Virtual_Final_New_IDOTweenInit_Int32_Int32_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Internal_IEnumerator_Tween_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_WaitForRewind_Internal_IEnumerator_Tween_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_WaitForKill_Internal_IEnumerator_Tween_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_WaitForElapsedLoops_Internal_IEnumerator_Tween_Int32_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_WaitForPosition_Internal_IEnumerator_Tween_Single_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_WaitForStart_Internal_IEnumerator_Tween_0;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_Void_0;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeMethodInfoPtr_DestroyInstance_Internal_Static_Void_0;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000E6 RID: 230
		[ObfuscatedName("DG.Tweening.Core.DOTweenComponent+<WaitForCompletion>d__14")]
		public sealed class _WaitForCompletion_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x06000839 RID: 2105 RVA: 0x00026C0C File Offset: 0x00024E0C
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForCompletion_d__14()
			{
				Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "<WaitForCompletion>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__14>.NativeClassPtr);
				DOTweenComponent._WaitForCompletion_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__14>.NativeClassPtr, "<>1__state");
				DOTweenComponent._WaitForCompletion_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__14>.NativeClassPtr, "<>2__current");
				DOTweenComponent._WaitForCompletion_d__14.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__14>.NativeClassPtr, "t");
				DOTweenComponent._WaitForCompletion_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__14>.NativeClassPtr, 100664190);
				DOTweenComponent._WaitForCompletion_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__14>.NativeClassPtr, 100664191);
				DOTweenComponent._WaitForCompletion_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__14>.NativeClassPtr, 100664192);
				DOTweenComponent._WaitForCompletion_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__14>.NativeClassPtr, 100664193);
				DOTweenComponent._WaitForCompletion_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__14>.NativeClassPtr, 100664194);
				DOTweenComponent._WaitForCompletion_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__14>.NativeClassPtr, 100664195);
			}

			// Token: 0x0600083A RID: 2106 RVA: 0x00026CEC File Offset: 0x00024EEC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForCompletion_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent._WaitForCompletion_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForCompletion_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600083B RID: 2107 RVA: 0x00026D34 File Offset: 0x00024F34
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForCompletion_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600083C RID: 2108 RVA: 0x00026D68 File Offset: 0x00024F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133258, XrefRangeEnd = 1133259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForCompletion_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x0600083D RID: 2109 RVA: 0x00026DA4 File Offset: 0x00024FA4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForCompletion_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600083E RID: 2110 RVA: 0x00026DE4 File Offset: 0x00024FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133259, XrefRangeEnd = 1133264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForCompletion_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x0600083F RID: 2111 RVA: 0x00026E18 File Offset: 0x00025018
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForCompletion_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000840 RID: 2112 RVA: 0x00004D91 File Offset: 0x00002F91
			public _WaitForCompletion_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700017D RID: 381
			// (get) Token: 0x06000841 RID: 2113 RVA: 0x00026E58 File Offset: 0x00025058
			// (set) Token: 0x06000842 RID: 2114 RVA: 0x00004D9A File Offset: 0x00002F9A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForCompletion_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForCompletion_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700017E RID: 382
			// (get) Token: 0x06000843 RID: 2115 RVA: 0x00026E80 File Offset: 0x00025080
			// (set) Token: 0x06000844 RID: 2116 RVA: 0x00004DB5 File Offset: 0x00002FB5
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForCompletion_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForCompletion_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x06000845 RID: 2117 RVA: 0x00026EB0 File Offset: 0x000250B0
			// (set) Token: 0x06000846 RID: 2118 RVA: 0x00004DD4 File Offset: 0x00002FD4
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForCompletion_d__14.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForCompletion_d__14.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000609 RID: 1545
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400060A RID: 1546
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400060B RID: 1547
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x0400060C RID: 1548
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400060D RID: 1549
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400060E RID: 1550
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400060F RID: 1551
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000610 RID: 1552
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000611 RID: 1553
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000E7 RID: 231
		[ObfuscatedName("DG.Tweening.Core.DOTweenComponent+<WaitForRewind>d__15")]
		public sealed class _WaitForRewind_d__15 : global::Il2CppSystem.Object
		{
			// Token: 0x06000847 RID: 2119 RVA: 0x00026EE0 File Offset: 0x000250E0
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForRewind_d__15()
			{
				Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "<WaitForRewind>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__15>.NativeClassPtr);
				DOTweenComponent._WaitForRewind_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__15>.NativeClassPtr, "<>1__state");
				DOTweenComponent._WaitForRewind_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__15>.NativeClassPtr, "<>2__current");
				DOTweenComponent._WaitForRewind_d__15.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__15>.NativeClassPtr, "t");
				DOTweenComponent._WaitForRewind_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__15>.NativeClassPtr, 100664196);
				DOTweenComponent._WaitForRewind_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__15>.NativeClassPtr, 100664197);
				DOTweenComponent._WaitForRewind_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__15>.NativeClassPtr, 100664198);
				DOTweenComponent._WaitForRewind_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__15>.NativeClassPtr, 100664199);
				DOTweenComponent._WaitForRewind_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__15>.NativeClassPtr, 100664200);
				DOTweenComponent._WaitForRewind_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__15>.NativeClassPtr, 100664201);
			}

			// Token: 0x06000848 RID: 2120 RVA: 0x00026FC0 File Offset: 0x000251C0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForRewind_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent._WaitForRewind_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForRewind_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000849 RID: 2121 RVA: 0x00027008 File Offset: 0x00025208
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForRewind_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600084A RID: 2122 RVA: 0x0002703C File Offset: 0x0002523C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133264, XrefRangeEnd = 1133265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForRewind_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000185 RID: 389
			// (get) Token: 0x0600084B RID: 2123 RVA: 0x00027078 File Offset: 0x00025278
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForRewind_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600084C RID: 2124 RVA: 0x000270B8 File Offset: 0x000252B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133265, XrefRangeEnd = 1133270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForRewind_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000186 RID: 390
			// (get) Token: 0x0600084D RID: 2125 RVA: 0x000270EC File Offset: 0x000252EC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForRewind_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600084E RID: 2126 RVA: 0x00004DF3 File Offset: 0x00002FF3
			public _WaitForRewind_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000182 RID: 386
			// (get) Token: 0x0600084F RID: 2127 RVA: 0x0002712C File Offset: 0x0002532C
			// (set) Token: 0x06000850 RID: 2128 RVA: 0x00004DFC File Offset: 0x00002FFC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForRewind_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForRewind_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000183 RID: 387
			// (get) Token: 0x06000851 RID: 2129 RVA: 0x00027154 File Offset: 0x00025354
			// (set) Token: 0x06000852 RID: 2130 RVA: 0x00004E17 File Offset: 0x00003017
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForRewind_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForRewind_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000184 RID: 388
			// (get) Token: 0x06000853 RID: 2131 RVA: 0x00027184 File Offset: 0x00025384
			// (set) Token: 0x06000854 RID: 2132 RVA: 0x00004E36 File Offset: 0x00003036
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForRewind_d__15.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForRewind_d__15.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000612 RID: 1554
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000613 RID: 1555
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000614 RID: 1556
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04000615 RID: 1557
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000616 RID: 1558
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000617 RID: 1559
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000618 RID: 1560
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000619 RID: 1561
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400061A RID: 1562
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000E8 RID: 232
		[ObfuscatedName("DG.Tweening.Core.DOTweenComponent+<WaitForKill>d__16")]
		public sealed class _WaitForKill_d__16 : global::Il2CppSystem.Object
		{
			// Token: 0x06000855 RID: 2133 RVA: 0x000271B4 File Offset: 0x000253B4
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForKill_d__16()
			{
				Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "<WaitForKill>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__16>.NativeClassPtr);
				DOTweenComponent._WaitForKill_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__16>.NativeClassPtr, "<>1__state");
				DOTweenComponent._WaitForKill_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__16>.NativeClassPtr, "<>2__current");
				DOTweenComponent._WaitForKill_d__16.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__16>.NativeClassPtr, "t");
				DOTweenComponent._WaitForKill_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__16>.NativeClassPtr, 100664202);
				DOTweenComponent._WaitForKill_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__16>.NativeClassPtr, 100664203);
				DOTweenComponent._WaitForKill_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__16>.NativeClassPtr, 100664204);
				DOTweenComponent._WaitForKill_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__16>.NativeClassPtr, 100664205);
				DOTweenComponent._WaitForKill_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__16>.NativeClassPtr, 100664206);
				DOTweenComponent._WaitForKill_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__16>.NativeClassPtr, 100664207);
			}

			// Token: 0x06000856 RID: 2134 RVA: 0x00027294 File Offset: 0x00025494
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForKill_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent._WaitForKill_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForKill_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000857 RID: 2135 RVA: 0x000272DC File Offset: 0x000254DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForKill_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000858 RID: 2136 RVA: 0x00027310 File Offset: 0x00025510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133270, XrefRangeEnd = 1133271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForKill_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x06000859 RID: 2137 RVA: 0x0002734C File Offset: 0x0002554C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForKill_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600085A RID: 2138 RVA: 0x0002738C File Offset: 0x0002558C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133271, XrefRangeEnd = 1133276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForKill_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x0600085B RID: 2139 RVA: 0x000273C0 File Offset: 0x000255C0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForKill_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600085C RID: 2140 RVA: 0x00004E55 File Offset: 0x00003055
			public _WaitForKill_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000187 RID: 391
			// (get) Token: 0x0600085D RID: 2141 RVA: 0x00027400 File Offset: 0x00025600
			// (set) Token: 0x0600085E RID: 2142 RVA: 0x00004E5E File Offset: 0x0000305E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForKill_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForKill_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x0600085F RID: 2143 RVA: 0x00027428 File Offset: 0x00025628
			// (set) Token: 0x06000860 RID: 2144 RVA: 0x00004E79 File Offset: 0x00003079
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForKill_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForKill_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x06000861 RID: 2145 RVA: 0x00027458 File Offset: 0x00025658
			// (set) Token: 0x06000862 RID: 2146 RVA: 0x00004E98 File Offset: 0x00003098
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForKill_d__16.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForKill_d__16.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400061B RID: 1563
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400061C RID: 1564
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400061D RID: 1565
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x0400061E RID: 1566
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400061F RID: 1567
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000620 RID: 1568
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000621 RID: 1569
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000622 RID: 1570
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000623 RID: 1571
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000E9 RID: 233
		[ObfuscatedName("DG.Tweening.Core.DOTweenComponent+<WaitForElapsedLoops>d__17")]
		public sealed class _WaitForElapsedLoops_d__17 : global::Il2CppSystem.Object
		{
			// Token: 0x06000863 RID: 2147 RVA: 0x00027488 File Offset: 0x00025688
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForElapsedLoops_d__17()
			{
				Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "<WaitForElapsedLoops>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__17>.NativeClassPtr);
				DOTweenComponent._WaitForElapsedLoops_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__17>.NativeClassPtr, "<>1__state");
				DOTweenComponent._WaitForElapsedLoops_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__17>.NativeClassPtr, "<>2__current");
				DOTweenComponent._WaitForElapsedLoops_d__17.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__17>.NativeClassPtr, "t");
				DOTweenComponent._WaitForElapsedLoops_d__17.NativeFieldInfoPtr_elapsedLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__17>.NativeClassPtr, "elapsedLoops");
				DOTweenComponent._WaitForElapsedLoops_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__17>.NativeClassPtr, 100664208);
				DOTweenComponent._WaitForElapsedLoops_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__17>.NativeClassPtr, 100664209);
				DOTweenComponent._WaitForElapsedLoops_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__17>.NativeClassPtr, 100664210);
				DOTweenComponent._WaitForElapsedLoops_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__17>.NativeClassPtr, 100664211);
				DOTweenComponent._WaitForElapsedLoops_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__17>.NativeClassPtr, 100664212);
				DOTweenComponent._WaitForElapsedLoops_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__17>.NativeClassPtr, 100664213);
			}

			// Token: 0x06000864 RID: 2148 RVA: 0x0002757C File Offset: 0x0002577C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForElapsedLoops_d__17(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent._WaitForElapsedLoops_d__17>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForElapsedLoops_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000865 RID: 2149 RVA: 0x000275C4 File Offset: 0x000257C4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForElapsedLoops_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000866 RID: 2150 RVA: 0x000275F8 File Offset: 0x000257F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133276, XrefRangeEnd = 1133277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForElapsedLoops_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x06000867 RID: 2151 RVA: 0x00027634 File Offset: 0x00025834
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForElapsedLoops_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000868 RID: 2152 RVA: 0x00027674 File Offset: 0x00025874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133277, XrefRangeEnd = 1133282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForElapsedLoops_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x06000869 RID: 2153 RVA: 0x000276A8 File Offset: 0x000258A8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForElapsedLoops_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600086A RID: 2154 RVA: 0x00004EB7 File Offset: 0x000030B7
			public _WaitForElapsedLoops_d__17(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x0600086B RID: 2155 RVA: 0x000276E8 File Offset: 0x000258E8
			// (set) Token: 0x0600086C RID: 2156 RVA: 0x00004EC0 File Offset: 0x000030C0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x0600086D RID: 2157 RVA: 0x00027710 File Offset: 0x00025910
			// (set) Token: 0x0600086E RID: 2158 RVA: 0x00004EDB File Offset: 0x000030DB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700018E RID: 398
			// (get) Token: 0x0600086F RID: 2159 RVA: 0x00027740 File Offset: 0x00025940
			// (set) Token: 0x06000870 RID: 2160 RVA: 0x00004EFA File Offset: 0x000030FA
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__17.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__17.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700018F RID: 399
			// (get) Token: 0x06000871 RID: 2161 RVA: 0x00027770 File Offset: 0x00025970
			// (set) Token: 0x06000872 RID: 2162 RVA: 0x00004F19 File Offset: 0x00003119
			public unsafe int elapsedLoops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__17.NativeFieldInfoPtr_elapsedLoops);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForElapsedLoops_d__17.NativeFieldInfoPtr_elapsedLoops)) = value;
				}
			}

			// Token: 0x04000624 RID: 1572
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000625 RID: 1573
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000626 RID: 1574
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04000627 RID: 1575
			private static readonly IntPtr NativeFieldInfoPtr_elapsedLoops;

			// Token: 0x04000628 RID: 1576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000629 RID: 1577
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400062A RID: 1578
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400062B RID: 1579
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400062C RID: 1580
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400062D RID: 1581
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000EA RID: 234
		[ObfuscatedName("DG.Tweening.Core.DOTweenComponent+<WaitForPosition>d__18")]
		public sealed class _WaitForPosition_d__18 : global::Il2CppSystem.Object
		{
			// Token: 0x06000873 RID: 2163 RVA: 0x00027798 File Offset: 0x00025998
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForPosition_d__18()
			{
				Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "<WaitForPosition>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__18>.NativeClassPtr);
				DOTweenComponent._WaitForPosition_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__18>.NativeClassPtr, "<>1__state");
				DOTweenComponent._WaitForPosition_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__18>.NativeClassPtr, "<>2__current");
				DOTweenComponent._WaitForPosition_d__18.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__18>.NativeClassPtr, "t");
				DOTweenComponent._WaitForPosition_d__18.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__18>.NativeClassPtr, "position");
				DOTweenComponent._WaitForPosition_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__18>.NativeClassPtr, 100664214);
				DOTweenComponent._WaitForPosition_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__18>.NativeClassPtr, 100664215);
				DOTweenComponent._WaitForPosition_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__18>.NativeClassPtr, 100664216);
				DOTweenComponent._WaitForPosition_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__18>.NativeClassPtr, 100664217);
				DOTweenComponent._WaitForPosition_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__18>.NativeClassPtr, 100664218);
				DOTweenComponent._WaitForPosition_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__18>.NativeClassPtr, 100664219);
			}

			// Token: 0x06000874 RID: 2164 RVA: 0x0002788C File Offset: 0x00025A8C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForPosition_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent._WaitForPosition_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForPosition_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000875 RID: 2165 RVA: 0x000278D4 File Offset: 0x00025AD4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForPosition_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000876 RID: 2166 RVA: 0x00027908 File Offset: 0x00025B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133282, XrefRangeEnd = 1133283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForPosition_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000196 RID: 406
			// (get) Token: 0x06000877 RID: 2167 RVA: 0x00027944 File Offset: 0x00025B44
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForPosition_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000878 RID: 2168 RVA: 0x00027984 File Offset: 0x00025B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133283, XrefRangeEnd = 1133288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForPosition_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000197 RID: 407
			// (get) Token: 0x06000879 RID: 2169 RVA: 0x000279B8 File Offset: 0x00025BB8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForPosition_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600087A RID: 2170 RVA: 0x00004F34 File Offset: 0x00003134
			public _WaitForPosition_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x0600087B RID: 2171 RVA: 0x000279F8 File Offset: 0x00025BF8
			// (set) Token: 0x0600087C RID: 2172 RVA: 0x00004F3D File Offset: 0x0000313D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x0600087D RID: 2173 RVA: 0x00027A20 File Offset: 0x00025C20
			// (set) Token: 0x0600087E RID: 2174 RVA: 0x00004F58 File Offset: 0x00003158
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000194 RID: 404
			// (get) Token: 0x0600087F RID: 2175 RVA: 0x00027A50 File Offset: 0x00025C50
			// (set) Token: 0x06000880 RID: 2176 RVA: 0x00004F77 File Offset: 0x00003177
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__18.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__18.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000195 RID: 405
			// (get) Token: 0x06000881 RID: 2177 RVA: 0x00027A80 File Offset: 0x00025C80
			// (set) Token: 0x06000882 RID: 2178 RVA: 0x00004F96 File Offset: 0x00003196
			public unsafe float position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__18.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForPosition_d__18.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x0400062E RID: 1582
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400062F RID: 1583
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000630 RID: 1584
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x04000631 RID: 1585
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04000632 RID: 1586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000633 RID: 1587
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000634 RID: 1588
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000635 RID: 1589
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000636 RID: 1590
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000637 RID: 1591
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020000EB RID: 235
		[ObfuscatedName("DG.Tweening.Core.DOTweenComponent+<WaitForStart>d__19")]
		public sealed class _WaitForStart_d__19 : global::Il2CppSystem.Object
		{
			// Token: 0x06000883 RID: 2179 RVA: 0x00027AA8 File Offset: 0x00025CA8
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForStart_d__19()
			{
				Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTweenComponent>.NativeClassPtr, "<WaitForStart>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__19>.NativeClassPtr);
				DOTweenComponent._WaitForStart_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__19>.NativeClassPtr, "<>1__state");
				DOTweenComponent._WaitForStart_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__19>.NativeClassPtr, "<>2__current");
				DOTweenComponent._WaitForStart_d__19.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__19>.NativeClassPtr, "t");
				DOTweenComponent._WaitForStart_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__19>.NativeClassPtr, 100664220);
				DOTweenComponent._WaitForStart_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__19>.NativeClassPtr, 100664221);
				DOTweenComponent._WaitForStart_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__19>.NativeClassPtr, 100664222);
				DOTweenComponent._WaitForStart_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__19>.NativeClassPtr, 100664223);
				DOTweenComponent._WaitForStart_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__19>.NativeClassPtr, 100664224);
				DOTweenComponent._WaitForStart_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__19>.NativeClassPtr, 100664225);
			}

			// Token: 0x06000884 RID: 2180 RVA: 0x00027B88 File Offset: 0x00025D88
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForStart_d__19(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTweenComponent._WaitForStart_d__19>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForStart_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000885 RID: 2181 RVA: 0x00027BD0 File Offset: 0x00025DD0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForStart_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000886 RID: 2182 RVA: 0x00027C04 File Offset: 0x00025E04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133288, XrefRangeEnd = 1133289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForStart_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x06000887 RID: 2183 RVA: 0x00027C40 File Offset: 0x00025E40
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForStart_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000888 RID: 2184 RVA: 0x00027C80 File Offset: 0x00025E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1133289, XrefRangeEnd = 1133294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForStart_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x06000889 RID: 2185 RVA: 0x00027CB4 File Offset: 0x00025EB4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DOTweenComponent._WaitForStart_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600088A RID: 2186 RVA: 0x00004FB1 File Offset: 0x000031B1
			public _WaitForStart_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000198 RID: 408
			// (get) Token: 0x0600088B RID: 2187 RVA: 0x00027CF4 File Offset: 0x00025EF4
			// (set) Token: 0x0600088C RID: 2188 RVA: 0x00004FBA File Offset: 0x000031BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForStart_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForStart_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000199 RID: 409
			// (get) Token: 0x0600088D RID: 2189 RVA: 0x00027D1C File Offset: 0x00025F1C
			// (set) Token: 0x0600088E RID: 2190 RVA: 0x00004FD5 File Offset: 0x000031D5
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForStart_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForStart_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700019A RID: 410
			// (get) Token: 0x0600088F RID: 2191 RVA: 0x00027D4C File Offset: 0x00025F4C
			// (set) Token: 0x06000890 RID: 2192 RVA: 0x00004FF4 File Offset: 0x000031F4
			public unsafe Tween t
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForStart_d__19.NativeFieldInfoPtr_t);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DOTweenComponent._WaitForStart_d__19.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000638 RID: 1592
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000639 RID: 1593
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400063A RID: 1594
			private static readonly IntPtr NativeFieldInfoPtr_t;

			// Token: 0x0400063B RID: 1595
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400063C RID: 1596
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400063D RID: 1597
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400063E RID: 1598
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400063F RID: 1599
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000640 RID: 1600
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
