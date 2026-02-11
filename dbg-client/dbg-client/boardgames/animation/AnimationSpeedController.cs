using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.animation
{
	// Token: 0x020002B9 RID: 697
	public class AnimationSpeedController : MonoBehaviour
	{
		// Token: 0x060020E4 RID: 8420 RVA: 0x0008AF34 File Offset: 0x00089134
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationSpeedController()
		{
			Il2CppClassPointerStore<AnimationSpeedController>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.animation", "AnimationSpeedController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationSpeedController>.NativeClassPtr);
			AnimationSpeedController.NativeFieldInfoPtr_halfAffected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSpeedController>.NativeClassPtr, "halfAffected");
			AnimationSpeedController.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationSpeedController>.NativeClassPtr, "animator");
			AnimationSpeedController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSpeedController>.NativeClassPtr, 100668750);
			AnimationSpeedController.NativeMethodInfoPtr_UpdateSpeed_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSpeedController>.NativeClassPtr, 100668751);
			AnimationSpeedController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSpeedController>.NativeClassPtr, 100668752);
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x0008AFC8 File Offset: 0x000891C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542833, XrefRangeEnd = 542838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSpeedController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x0008AFFC File Offset: 0x000891FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 542848, RefRangeEnd = 542850, XrefRangeStart = 542838, XrefRangeEnd = 542848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSpeedController.NativeMethodInfoPtr_UpdateSpeed_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x0008B030 File Offset: 0x00089230
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationSpeedController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationSpeedController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationSpeedController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x0001136C File Offset: 0x0000F56C
		public AnimationSpeedController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x0008B06C File Offset: 0x0008926C
		// (set) Token: 0x060020EA RID: 8426 RVA: 0x00011375 File Offset: 0x0000F575
		public unsafe bool halfAffected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSpeedController.NativeFieldInfoPtr_halfAffected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSpeedController.NativeFieldInfoPtr_halfAffected)) = value;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x0008B094 File Offset: 0x00089294
		// (set) Token: 0x060020EC RID: 8428 RVA: 0x00011390 File Offset: 0x0000F590
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSpeedController.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationSpeedController.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeFieldInfoPtr_halfAffected;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeed_Protected_Void_0;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
