using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace zen.src.match.monobehaviours
{
	// Token: 0x02000071 RID: 113
	public class MecanimPileEmptyRenderer : VersionedSubscriber<EntityComponent>
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x000238B4 File Offset: 0x00021AB4
		// Note: this type is marked as 'beforefieldinit'.
		static MecanimPileEmptyRenderer()
		{
			Il2CppClassPointerStore<MecanimPileEmptyRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "MecanimPileEmptyRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MecanimPileEmptyRenderer>.NativeClassPtr);
			MecanimPileEmptyRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MecanimPileEmptyRenderer>.NativeClassPtr, "animator");
			MecanimPileEmptyRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MecanimPileEmptyRenderer>.NativeClassPtr, 100664251);
			MecanimPileEmptyRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MecanimPileEmptyRenderer>.NativeClassPtr, 100664252);
			MecanimPileEmptyRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MecanimPileEmptyRenderer>.NativeClassPtr, 100664253);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00023934 File Offset: 0x00021B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988351, XrefRangeEnd = 988355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MecanimPileEmptyRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00023968 File Offset: 0x00021B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988355, XrefRangeEnd = 988364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MecanimPileEmptyRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000239A4 File Offset: 0x00021BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988364, XrefRangeEnd = 988367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MecanimPileEmptyRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MecanimPileEmptyRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MecanimPileEmptyRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00004BC9 File Offset: 0x00002DC9
		public MecanimPileEmptyRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x000239E0 File Offset: 0x00021BE0
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x00004BD2 File Offset: 0x00002DD2
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MecanimPileEmptyRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MecanimPileEmptyRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
