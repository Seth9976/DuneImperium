using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000075 RID: 117
	public class DefaultReferenceResolver : Object
	{
		// Token: 0x06000A0B RID: 2571 RVA: 0x00041048 File Offset: 0x0003F248
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultReferenceResolver()
		{
			Il2CppClassPointerStore<DefaultReferenceResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "DefaultReferenceResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultReferenceResolver>.NativeClassPtr);
			DefaultReferenceResolver.NativeFieldInfoPtr__referenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultReferenceResolver>.NativeClassPtr, "_referenceCount");
			DefaultReferenceResolver.NativeMethodInfoPtr_GetMappings_Private_BidirectionalDictionary_2_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultReferenceResolver>.NativeClassPtr, 100665249);
			DefaultReferenceResolver.NativeMethodInfoPtr_ResolveReference_Public_Virtual_Final_New_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultReferenceResolver>.NativeClassPtr, 100665250);
			DefaultReferenceResolver.NativeMethodInfoPtr_GetReference_Public_Virtual_Final_New_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultReferenceResolver>.NativeClassPtr, 100665251);
			DefaultReferenceResolver.NativeMethodInfoPtr_AddReference_Public_Virtual_Final_New_Void_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultReferenceResolver>.NativeClassPtr, 100665252);
			DefaultReferenceResolver.NativeMethodInfoPtr_IsReferenced_Public_Virtual_Final_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultReferenceResolver>.NativeClassPtr, 100665253);
			DefaultReferenceResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultReferenceResolver>.NativeClassPtr, 100665254);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00041104 File Offset: 0x0003F304
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 748689, RefRangeEnd = 748693, XrefRangeStart = 748674, XrefRangeEnd = 748689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BidirectionalDictionary<string, Object> GetMappings(Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultReferenceResolver.NativeMethodInfoPtr_GetMappings_Private_BidirectionalDictionary_2_String_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BidirectionalDictionary<string, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00041154 File Offset: 0x0003F354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748693, XrefRangeEnd = 748697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ResolveReference(Object context, string reference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reference);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultReferenceResolver.NativeMethodInfoPtr_ResolveReference_Public_Virtual_Final_New_Object_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x000411B8 File Offset: 0x0003F3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748697, XrefRangeEnd = 748709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetReference(Object context, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultReferenceResolver.NativeMethodInfoPtr_GetReference_Public_Virtual_Final_New_String_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00041214 File Offset: 0x0003F414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748709, XrefRangeEnd = 748714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddReference(Object context, string reference, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(reference);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultReferenceResolver.NativeMethodInfoPtr_AddReference_Public_Virtual_Final_New_Void_Object_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0004127C File Offset: 0x0003F47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748714, XrefRangeEnd = 748718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsReferenced(Object context, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultReferenceResolver.NativeMethodInfoPtr_IsReferenced_Public_Virtual_Final_New_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000412DC File Offset: 0x0003F4DC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultReferenceResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultReferenceResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultReferenceResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000050A2 File Offset: 0x000032A2
		public DefaultReferenceResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00041318 File Offset: 0x0003F518
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x000050AB File Offset: 0x000032AB
		public unsafe int _referenceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultReferenceResolver.NativeFieldInfoPtr__referenceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultReferenceResolver.NativeFieldInfoPtr__referenceCount)) = value;
			}
		}

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeFieldInfoPtr__referenceCount;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_GetMappings_Private_BidirectionalDictionary_2_String_Object_Object_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_ResolveReference_Public_Virtual_Final_New_Object_Object_String_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_GetReference_Public_Virtual_Final_New_String_Object_Object_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_AddReference_Public_Virtual_Final_New_Void_Object_String_Object_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_IsReferenced_Public_Virtual_Final_New_Boolean_Object_Object_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
