using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x02000081 RID: 129
	public static class DocumentationUtils : Object
	{
		// Token: 0x06000893 RID: 2195 RVA: 0x0002DAB8 File Offset: 0x0002BCB8
		// Note: this type is marked as 'beforefieldinit'.
		static DocumentationUtils()
		{
			Il2CppClassPointerStore<DocumentationUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DocumentationUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentationUtils>.NativeClassPtr);
			DocumentationUtils.NativeMethodInfoPtr_GetHelpURL_Public_Static_String_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentationUtils>.NativeClassPtr, 100664651);
			DocumentationUtils.NativeMethodInfoPtr_TryGetHelpURL_Public_Static_Boolean_Type_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentationUtils>.NativeClassPtr, 100664652);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0002DB10 File Offset: 0x0002BD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965968, XrefRangeEnd = 965991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetHelpURL<TEnum>(TEnum mask = default(TEnum)) where TEnum : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TEnum).IsValueType)
				{
					TEnum tenum = mask;
					intPtr = ((tenum is string) ? IL2CPP.ManagedStringToIl2Cpp(tenum as string) : IL2CPP.Il2CppObjectBaseToPtr(tenum as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref mask;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DocumentationUtils.MethodInfoStoreGeneric_GetHelpURL_Public_Static_String_TEnum_0<TEnum>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0002DB84 File Offset: 0x0002BD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965991, XrefRangeEnd = 965996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetHelpURL(Type type, out string url)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DocumentationUtils.NativeMethodInfoPtr_TryGetHelpURL_Public_Static_Boolean_Type_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			url = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00005625 File Offset: 0x00003825
		public DocumentationUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr_GetHelpURL_Public_Static_String_TEnum_0;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr_TryGetHelpURL_Public_Static_Boolean_Type_byref_String_0;

		// Token: 0x020001BA RID: 442
		private sealed class MethodInfoStoreGeneric_GetHelpURL_Public_Static_String_TEnum_0<TEnum>
		{
			// Token: 0x040011A7 RID: 4519
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DocumentationUtils.NativeMethodInfoPtr_GetHelpURL_Public_Static_String_TEnum_0, Il2CppClassPointerStore<DocumentationUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr)) }))));
		}
	}
}
