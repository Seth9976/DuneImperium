using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.messages
{
	// Token: 0x02000019 RID: 25
	public class AttributeModified : GameMessage
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x00008008 File Offset: 0x00006208
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeModified()
		{
			Il2CppClassPointerStore<AttributeModified>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "AttributeModified");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeModified>.NativeClassPtr);
			AttributeModified.NativeFieldInfoPtr_EntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeModified>.NativeClassPtr, "EntityID");
			AttributeModified.NativeFieldInfoPtr_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeModified>.NativeClassPtr, "Attribute");
			AttributeModified.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeModified>.NativeClassPtr, 100663336);
			AttributeModified.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeModified>.NativeClassPtr, 100663337);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00008088 File Offset: 0x00006288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193521, XrefRangeEnd = 1193540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributeModified.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000080CC File Offset: 0x000062CC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeModified()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeModified>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeModified.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002855 File Offset: 0x00000A55
		public AttributeModified(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00008108 File Offset: 0x00006308
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000285E File Offset: 0x00000A5E
		public unsafe EntityID EntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeModified.NativeFieldInfoPtr_EntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeModified.NativeFieldInfoPtr_EntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00008138 File Offset: 0x00006338
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000287D File Offset: 0x00000A7D
		public unsafe IAttribute Attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeModified.NativeFieldInfoPtr_Attribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributeModified.NativeFieldInfoPtr_Attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_EntityID;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_Attribute;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
