using System;
using Canis;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.entities
{
	// Token: 0x0200003D RID: 61
	public class WormUnit : WormEntity
	{
		// Token: 0x0600051C RID: 1308 RVA: 0x0007EA48 File Offset: 0x0007CC48
		// Note: this type is marked as 'beforefieldinit'.
		static WormUnit()
		{
			Il2CppClassPointerStore<WormUnit>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormUnit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormUnit>.NativeClassPtr);
			WormUnit.NativeMethodInfoPtr_get_Strength_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUnit>.NativeClassPtr, 100664716);
			WormUnit.NativeMethodInfoPtr__ctor_Protected_Void_Match_PlayerEntity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUnit>.NativeClassPtr, 100664717);
			WormUnit.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormUnit>.NativeClassPtr, 100664718);
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0007EAB4 File Offset: 0x0007CCB4
		public unsafe virtual int Strength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49126, XrefRangeEnd = 49137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormUnit.NativeMethodInfoPtr_get_Strength_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0007EAFC File Offset: 0x0007CCFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49161, RefRangeEnd = 49162, XrefRangeStart = 49137, XrefRangeEnd = 49161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormUnit(Match m, PlayerEntity owner, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormUnit>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormUnit.NativeMethodInfoPtr__ctor_Protected_Void_Match_PlayerEntity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0007EB6C File Offset: 0x0007CD6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49124, RefRangeEnd = 49126, XrefRangeStart = 49124, XrefRangeEnd = 49126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormUnit(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormUnit>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormUnit.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00003DA6 File Offset: 0x00001FA6
		public WormUnit(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_get_Strength_Public_Virtual_New_get_Int32_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_PlayerEntity_String_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_Match_Entity_0;
	}
}
