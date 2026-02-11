using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200041B RID: 1051
	public sealed class Missing : Object
	{
		// Token: 0x06003C6C RID: 15468 RVA: 0x00121DA8 File Offset: 0x0011FFA8
		// Note: this type is marked as 'beforefieldinit'.
		static Missing()
		{
			Il2CppClassPointerStore<Missing>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "Missing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Missing>.NativeClassPtr);
			Missing.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Missing>.NativeClassPtr, "Value");
			Missing.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Missing>.NativeClassPtr, 100672326);
			Missing.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Missing>.NativeClassPtr, 100672327);
		}

		// Token: 0x06003C6D RID: 15469 RVA: 0x00121E14 File Offset: 0x00120014
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Missing()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Missing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Missing.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x00121E50 File Offset: 0x00120050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1398888, XrefRangeEnd = 1398900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Missing.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x000165FA File Offset: 0x000147FA
		public Missing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06003C70 RID: 15472 RVA: 0x00121EAC File Offset: 0x001200AC
		// (set) Token: 0x06003C71 RID: 15473 RVA: 0x00016603 File Offset: 0x00014803
		public unsafe static Missing Value
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Missing.NativeFieldInfoPtr_Value, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Missing>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Missing.NativeFieldInfoPtr_Value, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400313E RID: 12606
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x0400313F RID: 12607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04003140 RID: 12608
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;
	}
}
