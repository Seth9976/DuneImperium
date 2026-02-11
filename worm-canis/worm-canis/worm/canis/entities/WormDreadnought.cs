using System;
using Canis;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.entities
{
	// Token: 0x02000026 RID: 38
	public class WormDreadnought : WormUnit
	{
		// Token: 0x06000341 RID: 833 RVA: 0x00075D14 File Offset: 0x00073F14
		// Note: this type is marked as 'beforefieldinit'.
		static WormDreadnought()
		{
			Il2CppClassPointerStore<WormDreadnought>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormDreadnought");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormDreadnought>.NativeClassPtr);
			WormDreadnought.NativeMethodInfoPtr_get_Strength_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDreadnought>.NativeClassPtr, 100664000);
			WormDreadnought.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDreadnought>.NativeClassPtr, 100664001);
			WormDreadnought.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormDreadnought>.NativeClassPtr, 100664002);
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00075D80 File Offset: 0x00073F80
		public unsafe override int Strength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35671, XrefRangeEnd = 35683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormDreadnought.NativeMethodInfoPtr_get_Strength_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00075DC8 File Offset: 0x00073FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35689, RefRangeEnd = 35690, XrefRangeStart = 35683, XrefRangeEnd = 35689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDreadnought(Match m, PlayerEntity owner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDreadnought>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDreadnought.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00075E28 File Offset: 0x00074028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35691, RefRangeEnd = 35692, XrefRangeStart = 35690, XrefRangeEnd = 35691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormDreadnought(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormDreadnought>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormDreadnought.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000368A File Offset: 0x0000188A
		public WormDreadnought(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_get_Strength_Public_Virtual_get_Int32_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;
	}
}
