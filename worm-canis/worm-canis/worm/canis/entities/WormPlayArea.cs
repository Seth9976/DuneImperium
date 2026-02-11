using System;
using Canis;
using Canis.entities;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.entities
{
	// Token: 0x02000030 RID: 48
	public class WormPlayArea : WormEntity
	{
		// Token: 0x060003B6 RID: 950 RVA: 0x000781A0 File Offset: 0x000763A0
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayArea()
		{
			Il2CppClassPointerStore<WormPlayArea>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormPlayArea");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayArea>.NativeClassPtr);
			WormPlayArea.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayArea>.NativeClassPtr, 100664152);
			WormPlayArea.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_PlayerEntity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayArea>.NativeClassPtr, 100664153);
			WormPlayArea.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayArea>.NativeClassPtr, 100664154);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0007820C File Offset: 0x0007640C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 38988, RefRangeEnd = 39005, XrefRangeStart = 38986, XrefRangeEnd = 38988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayArea(WormMatch m, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayArea>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayArea.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0007826C File Offset: 0x0007646C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39007, RefRangeEnd = 39008, XrefRangeStart = 39005, XrefRangeEnd = 39007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayArea(WormMatch m, PlayerEntity owner, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayArea>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayArea.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_PlayerEntity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000782DC File Offset: 0x000764DC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 35396, RefRangeEnd = 35408, XrefRangeStart = 35396, XrefRangeEnd = 35408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayArea(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayArea>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayArea.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000037B4 File Offset: 0x000019B4
		public WormPlayArea(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_String_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_PlayerEntity_String_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;
	}
}
