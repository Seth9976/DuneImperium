using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.match.commands
{
	// Token: 0x02000171 RID: 369
	public class SequenceCommandConstructorAttribute : Attribute
	{
		// Token: 0x06001540 RID: 5440 RVA: 0x00068FAC File Offset: 0x000671AC
		// Note: this type is marked as 'beforefieldinit'.
		static SequenceCommandConstructorAttribute()
		{
			Il2CppClassPointerStore<SequenceCommandConstructorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.commands", "SequenceCommandConstructorAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceCommandConstructorAttribute>.NativeClassPtr);
			SequenceCommandConstructorAttribute.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommandConstructorAttribute>.NativeClassPtr, "Name");
			SequenceCommandConstructorAttribute.NativeFieldInfoPtr_IsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceCommandConstructorAttribute>.NativeClassPtr, "IsOverride");
			SequenceCommandConstructorAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceCommandConstructorAttribute>.NativeClassPtr, 100666508);
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00069018 File Offset: 0x00067218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875949, XrefRangeEnd = 875951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequenceCommandConstructorAttribute(string name, bool isOverride = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceCommandConstructorAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequenceCommandConstructorAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x00009629 File Offset: 0x00007829
		public SequenceCommandConstructorAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x00069074 File Offset: 0x00067274
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x00009632 File Offset: 0x00007832
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommandConstructorAttribute.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommandConstructorAttribute.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x0006909C File Offset: 0x0006729C
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x00009651 File Offset: 0x00007851
		public unsafe bool IsOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommandConstructorAttribute.NativeFieldInfoPtr_IsOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SequenceCommandConstructorAttribute.NativeFieldInfoPtr_IsOverride)) = value;
			}
		}

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeFieldInfoPtr_IsOverride;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;
	}
}
