using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using voodoo;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x02000127 RID: 295
	public class WormFirstPlayerRenderer : VersionedDataComponentObserver<WormFirstPlayerData>
	{
		// Token: 0x06000D7B RID: 3451 RVA: 0x00040DE8 File Offset: 0x0003EFE8
		// Note: this type is marked as 'beforefieldinit'.
		static WormFirstPlayerRenderer()
		{
			Il2CppClassPointerStore<WormFirstPlayerRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormFirstPlayerRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormFirstPlayerRenderer>.NativeClassPtr);
			WormFirstPlayerRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFirstPlayerRenderer>.NativeClassPtr, "animator");
			WormFirstPlayerRenderer.NativeFieldInfoPtr_FirstPlayerOnParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFirstPlayerRenderer>.NativeClassPtr, "FirstPlayerOnParam");
			WormFirstPlayerRenderer.NativeFieldInfoPtr_FirstPlayerOffParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormFirstPlayerRenderer>.NativeClassPtr, "FirstPlayerOffParam");
			WormFirstPlayerRenderer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFirstPlayerRenderer>.NativeClassPtr, 100665134);
			WormFirstPlayerRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFirstPlayerRenderer>.NativeClassPtr, 100665135);
			WormFirstPlayerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormFirstPlayerRenderer>.NativeClassPtr, 100665136);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00040E90 File Offset: 0x0003F090
		[CallerCount(0)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFirstPlayerRenderer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00040EC4 File Offset: 0x0003F0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705675, XrefRangeEnd = 705690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void versionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormFirstPlayerRenderer.NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00040F00 File Offset: 0x0003F100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 705690, XrefRangeEnd = 705693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormFirstPlayerRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormFirstPlayerRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormFirstPlayerRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00009238 File Offset: 0x00007438
		public WormFirstPlayerRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00040F3C File Offset: 0x0003F13C
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x00009241 File Offset: 0x00007441
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFirstPlayerRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormFirstPlayerRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x00040F6C File Offset: 0x0003F16C
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00009260 File Offset: 0x00007460
		public unsafe static int FirstPlayerOnParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormFirstPlayerRenderer.NativeFieldInfoPtr_FirstPlayerOnParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormFirstPlayerRenderer.NativeFieldInfoPtr_FirstPlayerOnParam, (void*)(&value));
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00040F88 File Offset: 0x0003F188
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x0000926E File Offset: 0x0000746E
		public unsafe static int FirstPlayerOffParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormFirstPlayerRenderer.NativeFieldInfoPtr_FirstPlayerOffParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormFirstPlayerRenderer.NativeFieldInfoPtr_FirstPlayerOffParam, (void*)(&value));
			}
		}

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeFieldInfoPtr_FirstPlayerOnParam;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr_FirstPlayerOffParam;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_versionChanged_Protected_Virtual_Void_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
