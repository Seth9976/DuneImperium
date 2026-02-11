using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace JsonFx.Serialization.GraphCycles
{
	// Token: 0x0200001B RID: 27
	public class GraphCycleException : SerializationException
	{
		// Token: 0x06000143 RID: 323 RVA: 0x00008658 File Offset: 0x00006858
		// Note: this type is marked as 'beforefieldinit'.
		static GraphCycleException()
		{
			Il2CppClassPointerStore<GraphCycleException>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization.GraphCycles", "GraphCycleException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphCycleException>.NativeClassPtr);
			GraphCycleException.NativeFieldInfoPtr_GraphCycleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphCycleException>.NativeClassPtr, "GraphCycleType");
			GraphCycleException.NativeMethodInfoPtr__ctor_Public_Void_GraphCycleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphCycleException>.NativeClassPtr, 100663436);
			GraphCycleException.NativeMethodInfoPtr__ctor_Public_Void_GraphCycleType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphCycleException>.NativeClassPtr, 100663437);
			GraphCycleException.NativeMethodInfoPtr__ctor_Public_Void_GraphCycleType_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphCycleException>.NativeClassPtr, 100663438);
			GraphCycleException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphCycleException>.NativeClassPtr, 100663439);
			GraphCycleException.NativeMethodInfoPtr_get_CycleType_Public_get_GraphCycleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphCycleException>.NativeClassPtr, 100663440);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00008700 File Offset: 0x00006900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191141, XrefRangeEnd = 1191142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphCycleException(GraphCycleType cycleType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphCycleException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cycleType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphCycleException.NativeMethodInfoPtr__ctor_Public_Void_GraphCycleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00008748 File Offset: 0x00006948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191142, XrefRangeEnd = 1191143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphCycleException(GraphCycleType cycleType, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphCycleException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cycleType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphCycleException.NativeMethodInfoPtr__ctor_Public_Void_GraphCycleType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000087A4 File Offset: 0x000069A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191143, XrefRangeEnd = 1191144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphCycleException(GraphCycleType cycleType, string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphCycleException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cycleType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphCycleException.NativeMethodInfoPtr__ctor_Public_Void_GraphCycleType_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00008810 File Offset: 0x00006A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphCycleException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphCycleException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphCycleException.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00008874 File Offset: 0x00006A74
		public unsafe GraphCycleType CycleType
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphCycleException.NativeMethodInfoPtr_get_CycleType_Public_get_GraphCycleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000285C File Offset: 0x00000A5C
		public GraphCycleException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000088B0 File Offset: 0x00006AB0
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002865 File Offset: 0x00000A65
		public unsafe GraphCycleType GraphCycleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphCycleException.NativeFieldInfoPtr_GraphCycleType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GraphCycleException.NativeFieldInfoPtr_GraphCycleType)) = value;
			}
		}

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_GraphCycleType;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GraphCycleType_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GraphCycleType_String_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GraphCycleType_String_Exception_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_get_CycleType_Public_get_GraphCycleType_0;
	}
}
