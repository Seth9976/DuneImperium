using System;
using Canis;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.entities
{
	// Token: 0x0200003C RID: 60
	public class WormTroop : WormUnit
	{
		// Token: 0x06000517 RID: 1303 RVA: 0x0007E8C4 File Offset: 0x0007CAC4
		// Note: this type is marked as 'beforefieldinit'.
		static WormTroop()
		{
			Il2CppClassPointerStore<WormTroop>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormTroop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTroop>.NativeClassPtr);
			WormTroop.NativeMethodInfoPtr_get_Strength_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroop>.NativeClassPtr, 100664713);
			WormTroop.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroop>.NativeClassPtr, 100664714);
			WormTroop.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormTroop>.NativeClassPtr, 100664715);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0007E930 File Offset: 0x0007CB30
		public unsafe override int Strength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49073, XrefRangeEnd = 49085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormTroop.NativeMethodInfoPtr_get_Strength_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0007E978 File Offset: 0x0007CB78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49114, RefRangeEnd = 49115, XrefRangeStart = 49085, XrefRangeEnd = 49114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTroop(Match m, PlayerEntity owner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTroop>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroop.NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0007E9D8 File Offset: 0x0007CBD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49124, RefRangeEnd = 49126, XrefRangeStart = 49115, XrefRangeEnd = 49124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTroop(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormTroop>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormTroop.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00003D9D File Offset: 0x00001F9D
		public WormTroop(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_get_Strength_Public_Virtual_get_Int32_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_PlayerEntity_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;
	}
}
