using System;
using Canis.utils.ids;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace worm.match.dataRenderers
{
	// Token: 0x02000159 RID: 345
	public class WormReservePileCountRenderer : VersionedView<ReadOnlyVersionedList<EntityComponent>>
	{
		// Token: 0x06000F6E RID: 3950 RVA: 0x000466B8 File Offset: 0x000448B8
		// Note: this type is marked as 'beforefieldinit'.
		static WormReservePileCountRenderer()
		{
			Il2CppClassPointerStore<WormReservePileCountRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormReservePileCountRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormReservePileCountRenderer>.NativeClassPtr);
			WormReservePileCountRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormReservePileCountRenderer>.NativeClassPtr, "text");
			WormReservePileCountRenderer.NativeFieldInfoPtr_archetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormReservePileCountRenderer>.NativeClassPtr, "archetype");
			WormReservePileCountRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReservePileCountRenderer>.NativeClassPtr, 100665381);
			WormReservePileCountRenderer.NativeMethodInfoPtr_SetArchetype_Public_Void_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReservePileCountRenderer>.NativeClassPtr, 100665382);
			WormReservePileCountRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReservePileCountRenderer>.NativeClassPtr, 100665383);
			WormReservePileCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReservePileCountRenderer>.NativeClassPtr, 100665384);
			WormReservePileCountRenderer.NativeMethodInfoPtr__dirtyUpdate_b__4_0_Private_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormReservePileCountRenderer>.NativeClassPtr, 100665385);
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00046774 File Offset: 0x00044974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707770, XrefRangeEnd = 707784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormReservePileCountRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x000467B0 File Offset: 0x000449B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 707785, RefRangeEnd = 707786, XrefRangeStart = 707784, XrefRangeEnd = 707785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArchetype(ArchetypeID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormReservePileCountRenderer.NativeMethodInfoPtr_SetArchetype_Public_Void_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x000467F4 File Offset: 0x000449F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707786, XrefRangeEnd = 707806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormReservePileCountRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00046830 File Offset: 0x00044A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707806, XrefRangeEnd = 707809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormReservePileCountRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormReservePileCountRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormReservePileCountRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0004686C File Offset: 0x00044A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 707809, XrefRangeEnd = 707824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__4_0(EntityComponent c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormReservePileCountRenderer.NativeMethodInfoPtr__dirtyUpdate_b__4_0_Private_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0000A23B File Offset: 0x0000843B
		public WormReservePileCountRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x000468BC File Offset: 0x00044ABC
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x0000A244 File Offset: 0x00008444
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReservePileCountRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReservePileCountRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x000468EC File Offset: 0x00044AEC
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x0000A263 File Offset: 0x00008463
		public unsafe ArchetypeID archetype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReservePileCountRenderer.NativeFieldInfoPtr_archetype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormReservePileCountRenderer.NativeFieldInfoPtr_archetype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008E0 RID: 2272
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040008E1 RID: 2273
		private static readonly IntPtr NativeFieldInfoPtr_archetype;

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeMethodInfoPtr_SetArchetype_Public_Void_ArchetypeID_0;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x040008E5 RID: 2277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__4_0_Private_Boolean_EntityComponent_0;
	}
}
