using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000014 RID: 20
	public class EmitSignalWhenVisible : MonoBehaviour
	{
		// Token: 0x060000AD RID: 173 RVA: 0x000052A0 File Offset: 0x000034A0
		// Note: this type is marked as 'beforefieldinit'.
		static EmitSignalWhenVisible()
		{
			Il2CppClassPointerStore<EmitSignalWhenVisible>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "EmitSignalWhenVisible");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmitSignalWhenVisible>.NativeClassPtr);
			EmitSignalWhenVisible.NativeFieldInfoPtr_signal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitSignalWhenVisible>.NativeClassPtr, "signal");
			EmitSignalWhenVisible.NativeFieldInfoPtr_cm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitSignalWhenVisible>.NativeClassPtr, "cm");
			EmitSignalWhenVisible.NativeFieldInfoPtr_csm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitSignalWhenVisible>.NativeClassPtr, "csm");
			EmitSignalWhenVisible.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSignalWhenVisible>.NativeClassPtr, 100663446);
			EmitSignalWhenVisible.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSignalWhenVisible>.NativeClassPtr, 100663447);
			EmitSignalWhenVisible.NativeMethodInfoPtr_onCameraUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSignalWhenVisible>.NativeClassPtr, 100663448);
			EmitSignalWhenVisible.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmitSignalWhenVisible>.NativeClassPtr, 100663449);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000535C File Offset: 0x0000355C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258517, XrefRangeEnd = 1258533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitSignalWhenVisible.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00005390 File Offset: 0x00003590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258533, XrefRangeEnd = 1258537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitSignalWhenVisible.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000053C4 File Offset: 0x000035C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258537, XrefRangeEnd = 1258541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onCameraUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitSignalWhenVisible.NativeMethodInfoPtr_onCameraUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000053F8 File Offset: 0x000035F8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmitSignalWhenVisible()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmitSignalWhenVisible>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmitSignalWhenVisible.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000245F File Offset: 0x0000065F
		public EmitSignalWhenVisible(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00005434 File Offset: 0x00003634
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002468 File Offset: 0x00000668
		public unsafe string signal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSignalWhenVisible.NativeFieldInfoPtr_signal);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSignalWhenVisible.NativeFieldInfoPtr_signal), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000545C File Offset: 0x0000365C
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002487 File Offset: 0x00000687
		public unsafe CameraUpdateManager cm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSignalWhenVisible.NativeFieldInfoPtr_cm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraUpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSignalWhenVisible.NativeFieldInfoPtr_cm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000548C File Offset: 0x0000368C
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000024A6 File Offset: 0x000006A6
		public unsafe CutSceneManager csm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSignalWhenVisible.NativeFieldInfoPtr_csm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CutSceneManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmitSignalWhenVisible.NativeFieldInfoPtr_csm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_signal;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_cm;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_csm;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_onCameraUpdate_Private_Void_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
