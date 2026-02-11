using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000011 RID: 17
	public class CutSceneSession : MonoBehaviour
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00004C6C File Offset: 0x00002E6C
		// Note: this type is marked as 'beforefieldinit'.
		static CutSceneSession()
		{
			Il2CppClassPointerStore<CutSceneSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "CutSceneSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CutSceneSession>.NativeClassPtr);
			CutSceneSession.NativeFieldInfoPtr_ignoredScenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CutSceneSession>.NativeClassPtr, "ignoredScenes");
			CutSceneSession.NativeMethodInfoPtr_Add_Public_Void_CutScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSession>.NativeClassPtr, 100663416);
			CutSceneSession.NativeMethodInfoPtr_ShouldIgnore_Public_Boolean_CutScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSession>.NativeClassPtr, 100663417);
			CutSceneSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CutSceneSession>.NativeClassPtr, 100663418);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00004CEC File Offset: 0x00002EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258425, XrefRangeEnd = 1258429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(CutScene cs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSession.NativeMethodInfoPtr_Add_Public_Void_CutScene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004D30 File Offset: 0x00002F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258429, XrefRangeEnd = 1258433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldIgnore(CutScene cs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSession.NativeMethodInfoPtr_ShouldIgnore_Public_Boolean_CutScene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00004D80 File Offset: 0x00002F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258433, XrefRangeEnd = 1258441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CutSceneSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CutSceneSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CutSceneSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002392 File Offset: 0x00000592
		public CutSceneSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00004DBC File Offset: 0x00002FBC
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000239B File Offset: 0x0000059B
		public unsafe HashSet<string> ignoredScenes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSession.NativeFieldInfoPtr_ignoredScenes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CutSceneSession.NativeFieldInfoPtr_ignoredScenes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_ignoredScenes;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_CutScene_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIgnore_Public_Boolean_CutScene_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
