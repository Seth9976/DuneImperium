using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using Unity.Collections;

namespace UnityEngine
{
	// Token: 0x02000151 RID: 337
	public class TextAsset : Object
	{
		// Token: 0x06001938 RID: 6456 RVA: 0x00076558 File Offset: 0x00074758
		// Note: this type is marked as 'beforefieldinit'.
		static TextAsset()
		{
			Il2CppClassPointerStore<TextAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TextAsset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextAsset>.NativeClassPtr);
			TextAsset.NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100666771);
			TextAsset.NativeMethodInfoPtr_Internal_CreateInstance_Private_Static_Void_TextAsset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100666772);
			TextAsset.NativeMethodInfoPtr_GetDataPtr_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100666773);
			TextAsset.NativeMethodInfoPtr_GetDataSize_Private_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100666774);
			TextAsset.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100666775);
			TextAsset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100666776);
			TextAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100666777);
			TextAsset.NativeMethodInfoPtr__ctor_Internal_Void_CreateOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100666778);
			TextAsset.NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100666779);
			TextAsset.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, 100666780);
			TextAsset.GetPreviewBytesDelegateField = IL2CPP.ResolveICall<TextAsset.GetPreviewBytesDelegate>("UnityEngine.TextAsset::GetPreviewBytes");
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x00076660 File Offset: 0x00074860
		public unsafe Il2CppStructArray<byte> bytes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667354, XrefRangeEnd = 667356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x000766A0 File Offset: 0x000748A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667356, XrefRangeEnd = 667358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CreateInstance(TextAsset self, string text)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_Internal_CreateInstance_Private_Static_Void_TextAsset_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x000766E8 File Offset: 0x000748E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 667360, RefRangeEnd = 667361, XrefRangeStart = 667358, XrefRangeEnd = 667360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetDataPtr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_GetDataPtr_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00076724 File Offset: 0x00074924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 667363, RefRangeEnd = 667364, XrefRangeStart = 667361, XrefRangeEnd = 667363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetDataSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_GetDataSize_Private_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x00076760 File Offset: 0x00074960
		public unsafe string text
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 667368, RefRangeEnd = 667376, XrefRangeStart = 667364, XrefRangeEnd = 667368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00076798 File Offset: 0x00074998
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 667368, RefRangeEnd = 667376, XrefRangeStart = 667368, XrefRangeEnd = 667376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextAsset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x000767DC File Offset: 0x000749DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667376, XrefRangeEnd = 667382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextAsset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAsset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00076818 File Offset: 0x00074A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667382, XrefRangeEnd = 667388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextAsset(TextAsset.CreateOptions options, string text)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAsset>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref options;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr__ctor_Internal_Void_CreateOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00076874 File Offset: 0x00074A74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 667393, RefRangeEnd = 667397, XrefRangeStart = 667388, XrefRangeEnd = 667393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Collections.NativeArray<T> GetData<T>() where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Unity.Collections.NativeArray<T>(intPtr);
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x000768AC File Offset: 0x00074AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667397, XrefRangeEnd = 667414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DecodeString(Il2CppStructArray<byte> bytes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextAsset.NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00009D77 File Offset: 0x00007F77
		public TextAsset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000768E8 File Offset: 0x00074AE8
		public Il2CppStructArray<byte> GetPreviewBytes(int maxByteCount)
		{
			IntPtr intPtr = TextAsset.GetPreviewBytesDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), maxByteCount);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x00009D80 File Offset: 0x00007F80
		public long dataSize
		{
			get
			{
				return this.GetDataSize();
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00076918 File Offset: 0x00074B18
		public string GetPreview(int maxChars)
		{
			return TextAsset.DecodeString(this.GetPreviewBytes(maxChars * 4));
		}

		// Token: 0x04001676 RID: 5750
		private static readonly IntPtr NativeMethodInfoPtr_get_bytes_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001677 RID: 5751
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CreateInstance_Private_Static_Void_TextAsset_String_0;

		// Token: 0x04001678 RID: 5752
		private static readonly IntPtr NativeMethodInfoPtr_GetDataPtr_Private_IntPtr_0;

		// Token: 0x04001679 RID: 5753
		private static readonly IntPtr NativeMethodInfoPtr_GetDataSize_Private_Int64_0;

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400167C RID: 5756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400167D RID: 5757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CreateOptions_String_0;

		// Token: 0x0400167E RID: 5758
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_0;

		// Token: 0x0400167F RID: 5759
		private static readonly IntPtr NativeMethodInfoPtr_DecodeString_Internal_Static_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001680 RID: 5760
		private static readonly TextAsset.GetPreviewBytesDelegate GetPreviewBytesDelegateField;

		// Token: 0x0200075C RID: 1884
		public enum CreateOptions
		{
			// Token: 0x04002C73 RID: 11379
			None,
			// Token: 0x04002C74 RID: 11380
			CreateNativeObject
		}

		// Token: 0x0200075D RID: 1885
		public static class EncodingUtility : Object
		{
			// Token: 0x06003777 RID: 14199 RVA: 0x00013F7D File Offset: 0x0001217D
			// Note: this type is marked as 'beforefieldinit'.
			static EncodingUtility()
			{
				Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextAsset>.NativeClassPtr, "EncodingUtility");
				TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr, "encodingLookup");
				TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAsset.EncodingUtility>.NativeClassPtr, "targetEncoding");
			}

			// Token: 0x06003778 RID: 14200 RVA: 0x00013FBB File Offset: 0x000121BB
			public EncodingUtility(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A25 RID: 2597
			// (get) Token: 0x06003779 RID: 14201 RVA: 0x000BBDB8 File Offset: 0x000B9FB8
			// (set) Token: 0x0600377A RID: 14202 RVA: 0x00013FC4 File Offset: 0x000121C4
			public unsafe static Il2CppReferenceArray<KeyValuePair<Il2CppStructArray<byte>, Encoding>> encodingLookup
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyValuePair<Il2CppStructArray<byte>, Encoding>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_encodingLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A26 RID: 2598
			// (get) Token: 0x0600377B RID: 14203 RVA: 0x000BBDE0 File Offset: 0x000B9FE0
			// (set) Token: 0x0600377C RID: 14204 RVA: 0x00013FD6 File Offset: 0x000121D6
			public unsafe static Encoding targetEncoding
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TextAsset.EncodingUtility.NativeFieldInfoPtr_targetEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C75 RID: 11381
			private static readonly IntPtr NativeFieldInfoPtr_encodingLookup;

			// Token: 0x04002C76 RID: 11382
			private static readonly IntPtr NativeFieldInfoPtr_targetEncoding;
		}

		// Token: 0x0200075E RID: 1886
		private sealed class MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_0<T>
		{
			// Token: 0x04002C77 RID: 11383
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TextAsset.NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_0, Il2CppClassPointerStore<TextAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200075F RID: 1887
		// (Invoke) Token: 0x0600377F RID: 14207
		private delegate IntPtr GetPreviewBytesDelegate(IntPtr @this, int maxByteCount);
	}
}
