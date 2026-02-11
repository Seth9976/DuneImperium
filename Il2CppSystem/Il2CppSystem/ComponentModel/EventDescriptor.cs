using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200010A RID: 266
	public class EventDescriptor : MemberDescriptor
	{
		// Token: 0x06001098 RID: 4248 RVA: 0x00007E90 File Offset: 0x00006090
		// Note: this type is marked as 'beforefieldinit'.
		static EventDescriptor()
		{
			Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "EventDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr);
			EventDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_String_Il2CppReferenceArray_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr, 100665692);
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0005AF18 File Offset: 0x00059118
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 458985, RefRangeEnd = 458995, XrefRangeStart = 458984, XrefRangeEnd = 458985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDescriptor(string name, Il2CppReferenceArray<Attribute> attrs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDescriptor.NativeMethodInfoPtr__ctor_Protected_Void_String_Il2CppReferenceArray_1_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00007EC9 File Offset: 0x000060C9
		public EventDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Il2CppReferenceArray_1_Attribute_0;
	}
}
