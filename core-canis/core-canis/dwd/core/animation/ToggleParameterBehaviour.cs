using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.animation
{
	// Token: 0x02000217 RID: 535
	public class ToggleParameterBehaviour : MonoBehaviour
	{
		// Token: 0x06001D50 RID: 7504 RVA: 0x00087C50 File Offset: 0x00085E50
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleParameterBehaviour()
		{
			Il2CppClassPointerStore<ToggleParameterBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.animation", "ToggleParameterBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleParameterBehaviour>.NativeClassPtr);
			ToggleParameterBehaviour.NativeFieldInfoPtr_parameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterBehaviour>.NativeClassPtr, "parameterName");
			ToggleParameterBehaviour.NativeFieldInfoPtr_startsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterBehaviour>.NativeClassPtr, "startsActive");
			ToggleParameterBehaviour.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterBehaviour>.NativeClassPtr, "animator");
			ToggleParameterBehaviour.NativeFieldInfoPtr_parameterHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleParameterBehaviour>.NativeClassPtr, "parameterHash");
			ToggleParameterBehaviour.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterBehaviour>.NativeClassPtr, 100668024);
			ToggleParameterBehaviour.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterBehaviour>.NativeClassPtr, 100668025);
			ToggleParameterBehaviour.NativeMethodInfoPtr_Toggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterBehaviour>.NativeClassPtr, 100668026);
			ToggleParameterBehaviour.NativeMethodInfoPtr_SetParameter_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterBehaviour>.NativeClassPtr, 100668027);
			ToggleParameterBehaviour.NativeMethodInfoPtr_SetParameterInverse_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterBehaviour>.NativeClassPtr, 100668028);
			ToggleParameterBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleParameterBehaviour>.NativeClassPtr, 100668029);
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x00087D48 File Offset: 0x00085F48
		public unsafe bool IsActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886339, XrefRangeEnd = 886341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterBehaviour.NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00087D84 File Offset: 0x00085F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886341, XrefRangeEnd = 886352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterBehaviour.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00087DB8 File Offset: 0x00085FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886352, XrefRangeEnd = 886355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Toggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterBehaviour.NativeMethodInfoPtr_Toggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00087DEC File Offset: 0x00085FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886355, XrefRangeEnd = 886357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParameter(bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isActive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterBehaviour.NativeMethodInfoPtr_SetParameter_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x00087E2C File Offset: 0x0008602C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886357, XrefRangeEnd = 886359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParameterInverse(bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isActive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterBehaviour.NativeMethodInfoPtr_SetParameterInverse_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00087E6C File Offset: 0x0008606C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886359, XrefRangeEnd = 886364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleParameterBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleParameterBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleParameterBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x0000C7D7 File Offset: 0x0000A9D7
		public ToggleParameterBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00087EA8 File Offset: 0x000860A8
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		public unsafe string parameterName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterBehaviour.NativeFieldInfoPtr_parameterName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterBehaviour.NativeFieldInfoPtr_parameterName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00087ED0 File Offset: 0x000860D0
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x0000C7FF File Offset: 0x0000A9FF
		public unsafe bool startsActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterBehaviour.NativeFieldInfoPtr_startsActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterBehaviour.NativeFieldInfoPtr_startsActive)) = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x00087EF8 File Offset: 0x000860F8
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x0000C81A File Offset: 0x0000AA1A
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterBehaviour.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterBehaviour.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x00087F28 File Offset: 0x00086128
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x0000C839 File Offset: 0x0000AA39
		public unsafe int parameterHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterBehaviour.NativeFieldInfoPtr_parameterHash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleParameterBehaviour.NativeFieldInfoPtr_parameterHash)) = value;
			}
		}

		// Token: 0x04001489 RID: 5257
		private static readonly IntPtr NativeFieldInfoPtr_parameterName;

		// Token: 0x0400148A RID: 5258
		private static readonly IntPtr NativeFieldInfoPtr_startsActive;

		// Token: 0x0400148B RID: 5259
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x0400148C RID: 5260
		private static readonly IntPtr NativeFieldInfoPtr_parameterHash;

		// Token: 0x0400148D RID: 5261
		private static readonly IntPtr NativeMethodInfoPtr_get_IsActive_Public_get_Boolean_0;

		// Token: 0x0400148E RID: 5262
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400148F RID: 5263
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Void_0;

		// Token: 0x04001490 RID: 5264
		private static readonly IntPtr NativeMethodInfoPtr_SetParameter_Public_Void_Boolean_0;

		// Token: 0x04001491 RID: 5265
		private static readonly IntPtr NativeMethodInfoPtr_SetParameterInverse_Public_Void_Boolean_0;

		// Token: 0x04001492 RID: 5266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
