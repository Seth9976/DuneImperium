using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000A8 RID: 168
	[StructLayout(2)]
	public struct GraphicsBufferHandle
	{
		// Token: 0x06000DEB RID: 3563 RVA: 0x00045794 File Offset: 0x00043994
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsBufferHandle()
		{
			Il2CppClassPointerStore<GraphicsBufferHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GraphicsBufferHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsBufferHandle>.NativeClassPtr);
			GraphicsBufferHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsBufferHandle>.NativeClassPtr, "value");
			GraphicsBufferHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBufferHandle>.NativeClassPtr, 100665034);
			GraphicsBufferHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBufferHandle>.NativeClassPtr, 100665035);
			GraphicsBufferHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GraphicsBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsBufferHandle>.NativeClassPtr, 100665036);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x00045814 File Offset: 0x00043A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBufferHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x00045844 File Offset: 0x00043A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 653229, XrefRangeEnd = 653232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBufferHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00045888 File Offset: 0x00043A88
		[CallerCount(0)]
		public unsafe bool Equals(GraphicsBufferHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsBufferHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GraphicsBufferHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00006F48 File Offset: 0x00005148
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraphicsBufferHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x000458C8 File Offset: 0x00043AC8
		public int CompareTo(GraphicsBufferHandle other)
		{
			return this.value.CompareTo(other.value);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000458EC File Offset: 0x00043AEC
		public static bool operator ==(GraphicsBufferHandle a, GraphicsBufferHandle b)
		{
			return a.Equals(b);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00045908 File Offset: 0x00043B08
		public static bool operator !=(GraphicsBufferHandle a, GraphicsBufferHandle b)
		{
			return !a.Equals(b);
		}

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GraphicsBufferHandle_0;

		// Token: 0x04000B03 RID: 2819
		[FieldOffset(0)]
		public readonly uint value;
	}
}
