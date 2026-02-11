using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting.APIUpdating
{
	// Token: 0x020001BC RID: 444
	public class MovedFromAttribute : Attribute
	{
		// Token: 0x0600203B RID: 8251 RVA: 0x0008F824 File Offset: 0x0008DA24
		// Note: this type is marked as 'beforefieldinit'.
		static MovedFromAttribute()
		{
			Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting.APIUpdating", "MovedFromAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr);
			MovedFromAttribute.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr, "data");
			MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr, 100667679);
			MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr, 100667680);
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0008F890 File Offset: 0x0008DA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680054, XrefRangeEnd = 680056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref autoUpdateAPI;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceNamespace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceAssembly);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sourceClassName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0008F910 File Offset: 0x0008DB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 680056, XrefRangeEnd = 680060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MovedFromAttribute(string sourceNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceNamespace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0000C405 File Offset: 0x0000A605
		public MovedFromAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x0008F95C File Offset: 0x0008DB5C
		// (set) Token: 0x06002040 RID: 8256 RVA: 0x0000C40E File Offset: 0x0000A60E
		public MovedFromAttributeData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttribute.NativeFieldInfoPtr_data);
				return new MovedFromAttributeData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MovedFromAttribute.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x0000C43C File Offset: 0x0000A63C
		public bool AffectsAPIUpdater
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x0000C449 File Offset: 0x0000A649
		public bool IsInDifferentAssembly
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_String_0;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
