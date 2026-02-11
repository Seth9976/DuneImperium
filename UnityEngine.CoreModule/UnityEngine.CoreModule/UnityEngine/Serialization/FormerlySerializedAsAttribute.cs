using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Serialization
{
	// Token: 0x020001B9 RID: 441
	public class FormerlySerializedAsAttribute : Attribute
	{
		// Token: 0x06002020 RID: 8224 RVA: 0x0008F4A0 File Offset: 0x0008D6A0
		// Note: this type is marked as 'beforefieldinit'.
		static FormerlySerializedAsAttribute()
		{
			Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Serialization", "FormerlySerializedAsAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr);
			FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr, "m_oldName");
			FormerlySerializedAsAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr, 100667676);
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x0008F4F8 File Offset: 0x0008D6F8
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormerlySerializedAsAttribute(string oldName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormerlySerializedAsAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x0000C2B7 File Offset: 0x0000A4B7
		public FormerlySerializedAsAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06002023 RID: 8227 RVA: 0x0008F544 File Offset: 0x0008D744
		// (set) Token: 0x06002024 RID: 8228 RVA: 0x0000C2C0 File Offset: 0x0000A4C0
		public unsafe string m_oldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06002025 RID: 8229 RVA: 0x0008F56C File Offset: 0x0008D76C
		public string oldName
		{
			get
			{
				return this.m_oldName;
			}
		}

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeFieldInfoPtr_m_oldName;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
