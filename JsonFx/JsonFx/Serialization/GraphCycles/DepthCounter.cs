using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JsonFx.Serialization.GraphCycles
{
	// Token: 0x0200001A RID: 26
	public class DepthCounter : Object
	{
		// Token: 0x0600013A RID: 314 RVA: 0x00008498 File Offset: 0x00006698
		// Note: this type is marked as 'beforefieldinit'.
		static DepthCounter()
		{
			Il2CppClassPointerStore<DepthCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization.GraphCycles", "DepthCounter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthCounter>.NativeClassPtr);
			DepthCounter.NativeFieldInfoPtr_MaxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthCounter>.NativeClassPtr, "MaxDepth");
			DepthCounter.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthCounter>.NativeClassPtr, "depth");
			DepthCounter.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthCounter>.NativeClassPtr, 100663433);
			DepthCounter.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthCounter>.NativeClassPtr, 100663434);
			DepthCounter.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthCounter>.NativeClassPtr, 100663435);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000852C File Offset: 0x0000672C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191140, XrefRangeEnd = 1191141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DepthCounter(int maxDepth)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthCounter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxDepth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthCounter.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00008574 File Offset: 0x00006774
		[CallerCount(0)]
		public unsafe virtual bool Add(Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthCounter.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000085C4 File Offset: 0x000067C4
		[CallerCount(0)]
		public unsafe virtual void Remove(Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthCounter.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000281D File Offset: 0x00000A1D
		public DepthCounter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00008608 File Offset: 0x00006808
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002826 File Offset: 0x00000A26
		public unsafe int MaxDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthCounter.NativeFieldInfoPtr_MaxDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthCounter.NativeFieldInfoPtr_MaxDepth)) = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00008630 File Offset: 0x00006830
		// (set) Token: 0x06000142 RID: 322 RVA: 0x00002841 File Offset: 0x00000A41
		public unsafe int depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthCounter.NativeFieldInfoPtr_depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthCounter.NativeFieldInfoPtr_depth)) = value;
			}
		}

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_MaxDepth;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_depth;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0;
	}
}
