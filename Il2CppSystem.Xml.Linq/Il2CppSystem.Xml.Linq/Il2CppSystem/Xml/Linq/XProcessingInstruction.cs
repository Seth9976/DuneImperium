using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x0200001B RID: 27
	public class XProcessingInstruction : XNode
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00007FCC File Offset: 0x000061CC
		// Note: this type is marked as 'beforefieldinit'.
		static XProcessingInstruction()
		{
			Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "XProcessingInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr);
			XProcessingInstruction.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr, "target");
			XProcessingInstruction.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr, "data");
			XProcessingInstruction.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr, 100663522);
			XProcessingInstruction.NativeMethodInfoPtr__ctor_Public_Void_XProcessingInstruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr, 100663523);
			XProcessingInstruction.NativeMethodInfoPtr_get_Data_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr, 100663524);
			XProcessingInstruction.NativeMethodInfoPtr_set_Data_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr, 100663525);
			XProcessingInstruction.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr, 100663526);
			XProcessingInstruction.NativeMethodInfoPtr_get_Target_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr, 100663527);
			XProcessingInstruction.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr, 100663528);
			XProcessingInstruction.NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr, 100663529);
			XProcessingInstruction.NativeMethodInfoPtr_ValidateName_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr, 100663530);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000080D8 File Offset: 0x000062D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238578, RefRangeEnd = 1238579, XrefRangeStart = 1238555, XrefRangeEnd = 1238578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XProcessingInstruction(string target, string data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XProcessingInstruction.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00008138 File Offset: 0x00006338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238579, XrefRangeEnd = 1238588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XProcessingInstruction(XProcessingInstruction other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XProcessingInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XProcessingInstruction.NativeMethodInfoPtr__ctor_Public_Void_XProcessingInstruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00008184 File Offset: 0x00006384
		// (set) Token: 0x0600014B RID: 331 RVA: 0x000081BC File Offset: 0x000063BC
		public unsafe string Data
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XProcessingInstruction.NativeMethodInfoPtr_get_Data_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1238598, RefRangeEnd = 1238599, XrefRangeStart = 1238588, XrefRangeEnd = 1238598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XProcessingInstruction.NativeMethodInfoPtr_set_Data_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00008200 File Offset: 0x00006400
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XProcessingInstruction.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00008248 File Offset: 0x00006448
		public unsafe string Target
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XProcessingInstruction.NativeMethodInfoPtr_get_Target_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00008280 File Offset: 0x00006480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238599, XrefRangeEnd = 1238605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteTo(XmlWriter writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XProcessingInstruction.NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000082D0 File Offset: 0x000064D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238605, XrefRangeEnd = 1238611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XNode CloneNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XProcessingInstruction.NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XNode>(intPtr3) : null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000831C File Offset: 0x0000651C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238611, XrefRangeEnd = 1238618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XProcessingInstruction.NativeMethodInfoPtr_ValidateName_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000026A6 File Offset: 0x000008A6
		public XProcessingInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00008354 File Offset: 0x00006554
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000026AF File Offset: 0x000008AF
		public unsafe string target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XProcessingInstruction.NativeFieldInfoPtr_target);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XProcessingInstruction.NativeFieldInfoPtr_target), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000837C File Offset: 0x0000657C
		// (set) Token: 0x06000155 RID: 341 RVA: 0x000026CE File Offset: 0x000008CE
		public unsafe string data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XProcessingInstruction.NativeFieldInfoPtr_data);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XProcessingInstruction.NativeFieldInfoPtr_data), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XProcessingInstruction_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_String_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_String_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_String_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_WriteTo_Public_Virtual_Void_XmlWriter_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Internal_Virtual_XNode_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_ValidateName_Private_Static_Void_String_0;
	}
}
