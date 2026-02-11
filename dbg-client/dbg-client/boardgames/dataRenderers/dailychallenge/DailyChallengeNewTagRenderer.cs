using System;
using dbgclient.dataProviders;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.dataRenderers.dailychallenge
{
	// Token: 0x02000160 RID: 352
	public class DailyChallengeNewTagRenderer : DailyChallengeDataRenderer
	{
		// Token: 0x06000FBD RID: 4029 RVA: 0x0004F894 File Offset: 0x0004DA94
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeNewTagRenderer()
		{
			Il2CppClassPointerStore<DailyChallengeNewTagRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.dataRenderers.dailychallenge", "DailyChallengeNewTagRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeNewTagRenderer>.NativeClassPtr);
			DailyChallengeNewTagRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeNewTagRenderer>.NativeClassPtr, "animator");
			DailyChallengeNewTagRenderer.NativeFieldInfoPtr_currentVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeNewTagRenderer>.NativeClassPtr, "currentVersion");
			DailyChallengeNewTagRenderer.NativeFieldInfoPtr_EnableParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeNewTagRenderer>.NativeClassPtr, "EnableParam");
			DailyChallengeNewTagRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeNewTagRenderer>.NativeClassPtr, 100665541);
			DailyChallengeNewTagRenderer.NativeMethodInfoPtr_Event_OnClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeNewTagRenderer>.NativeClassPtr, 100665542);
			DailyChallengeNewTagRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeNewTagRenderer>.NativeClassPtr, 100665543);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0004F93C File Offset: 0x0004DB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513516, XrefRangeEnd = 513528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(DailyChallengeProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailyChallengeNewTagRenderer.NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0004F98C File Offset: 0x0004DB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 513528, XrefRangeEnd = 513539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeNewTagRenderer.NativeMethodInfoPtr_Event_OnClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0004F9C0 File Offset: 0x0004DBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeNewTagRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeNewTagRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeNewTagRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0000995C File Offset: 0x00007B5C
		public DailyChallengeNewTagRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x0004F9FC File Offset: 0x0004DBFC
		// (set) Token: 0x06000FC3 RID: 4035 RVA: 0x00009965 File Offset: 0x00007B65
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeNewTagRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeNewTagRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000FC4 RID: 4036 RVA: 0x0004FA2C File Offset: 0x0004DC2C
		// (set) Token: 0x06000FC5 RID: 4037 RVA: 0x00009984 File Offset: 0x00007B84
		public unsafe int currentVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeNewTagRenderer.NativeFieldInfoPtr_currentVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeNewTagRenderer.NativeFieldInfoPtr_currentVersion)) = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000FC6 RID: 4038 RVA: 0x0004FA54 File Offset: 0x0004DC54
		// (set) Token: 0x06000FC7 RID: 4039 RVA: 0x0000999F File Offset: 0x00007B9F
		public unsafe static int EnableParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(DailyChallengeNewTagRenderer.NativeFieldInfoPtr_EnableParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DailyChallengeNewTagRenderer.NativeFieldInfoPtr_EnableParam, (void*)(&value));
			}
		}

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeFieldInfoPtr_currentVersion;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeFieldInfoPtr_EnableParam;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Void_DailyChallengeProvider_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnClick_Public_Void_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
