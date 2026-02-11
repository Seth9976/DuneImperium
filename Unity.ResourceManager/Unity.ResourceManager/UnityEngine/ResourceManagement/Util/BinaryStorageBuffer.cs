using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000013 RID: 19
	public class BinaryStorageBuffer : Object
	{
		// Token: 0x0600014A RID: 330 RVA: 0x0000A200 File Offset: 0x00008400
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryStorageBuffer()
		{
			Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "BinaryStorageBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr);
			BinaryStorageBuffer.NativeFieldInfoPtr_kUnicodeStringFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, "kUnicodeStringFlag");
			BinaryStorageBuffer.NativeFieldInfoPtr_kDynamicStringFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, "kDynamicStringFlag");
			BinaryStorageBuffer.NativeFieldInfoPtr_kClearFlagsMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, "kClearFlagsMask");
			BinaryStorageBuffer.NativeMethodInfoPtr_ComputeHash_Private_Static_Void_ptr_Void_UInt64_ptr_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, 100663498);
			BinaryStorageBuffer.NativeMethodInfoPtr_AddSerializationAdapter_Private_Static_Void_Dictionary_2_Type_ISerializationAdapter_ISerializationAdapter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, 100663499);
			BinaryStorageBuffer.NativeMethodInfoPtr_GetSerializationAdapter_Private_Static_Boolean_Dictionary_2_Type_ISerializationAdapter_Type_byref_ISerializationAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, 100663500);
			BinaryStorageBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, 100663501);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000A2BC File Offset: 0x000084BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1138088, RefRangeEnd = 1138090, XrefRangeStart = 1138087, XrefRangeEnd = 1138088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ComputeHash(void* pData, ulong size, Hash128* hash)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = hash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.NativeMethodInfoPtr_ComputeHash_Private_Static_Void_ptr_Void_UInt64_ptr_Hash128_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000A308 File Offset: 0x00008508
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1138145, RefRangeEnd = 1138153, XrefRangeStart = 1138090, XrefRangeEnd = 1138145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddSerializationAdapter(Dictionary<Type, BinaryStorageBuffer.ISerializationAdapter> serializationAdapters, BinaryStorageBuffer.ISerializationAdapter adapter, bool forceOverride = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationAdapters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.NativeMethodInfoPtr_AddSerializationAdapter_Private_Static_Void_Dictionary_2_Type_ISerializationAdapter_ISerializationAdapter_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000A360 File Offset: 0x00008560
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1138171, RefRangeEnd = 1138173, XrefRangeStart = 1138153, XrefRangeEnd = 1138171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetSerializationAdapter(Dictionary<Type, BinaryStorageBuffer.ISerializationAdapter> serializationAdapters, Type t, out BinaryStorageBuffer.ISerializationAdapter adapter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationAdapters);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.NativeMethodInfoPtr_GetSerializationAdapter_Private_Static_Boolean_Dictionary_2_Type_ISerializationAdapter_Type_byref_ISerializationAdapter_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			adapter = ((intPtr4 == 0) ? null : new BinaryStorageBuffer.ISerializationAdapter(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000A3D8 File Offset: 0x000085D8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryStorageBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002897 File Offset: 0x00000A97
		public BinaryStorageBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000A414 File Offset: 0x00008614
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000028A0 File Offset: 0x00000AA0
		public unsafe static uint kUnicodeStringFlag
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(BinaryStorageBuffer.NativeFieldInfoPtr_kUnicodeStringFlag, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryStorageBuffer.NativeFieldInfoPtr_kUnicodeStringFlag, (void*)(&value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0000A430 File Offset: 0x00008630
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000028AE File Offset: 0x00000AAE
		public unsafe static uint kDynamicStringFlag
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(BinaryStorageBuffer.NativeFieldInfoPtr_kDynamicStringFlag, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryStorageBuffer.NativeFieldInfoPtr_kDynamicStringFlag, (void*)(&value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000A44C File Offset: 0x0000864C
		// (set) Token: 0x06000155 RID: 341 RVA: 0x000028BC File Offset: 0x00000ABC
		public unsafe static uint kClearFlagsMask
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(BinaryStorageBuffer.NativeFieldInfoPtr_kClearFlagsMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryStorageBuffer.NativeFieldInfoPtr_kClearFlagsMask, (void*)(&value));
			}
		}

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_kUnicodeStringFlag;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_kDynamicStringFlag;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_kClearFlagsMask;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_ComputeHash_Private_Static_Void_ptr_Void_UInt64_ptr_Hash128_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_AddSerializationAdapter_Private_Static_Void_Dictionary_2_Type_ISerializationAdapter_ISerializationAdapter_Boolean_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_GetSerializationAdapter_Private_Static_Boolean_Dictionary_2_Type_ISerializationAdapter_Type_byref_ISerializationAdapter_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000071 RID: 113
		public class BuiltinTypesSerializer : Object
		{
			// Token: 0x060005BD RID: 1469 RVA: 0x0001B958 File Offset: 0x00019B58
			// Note: this type is marked as 'beforefieldinit'.
			static BuiltinTypesSerializer()
			{
				Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, "BuiltinTypesSerializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer>.NativeClassPtr);
				BinaryStorageBuffer.BuiltinTypesSerializer.NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IEnumerable_1_ISerializationAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer>.NativeClassPtr, 100663502);
				BinaryStorageBuffer.BuiltinTypesSerializer.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Reader_Type_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer>.NativeClassPtr, 100663503);
				BinaryStorageBuffer.BuiltinTypesSerializer.NativeMethodInfoPtr_FindBestSeparator_Private_Char_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer>.NativeClassPtr, 100663504);
				BinaryStorageBuffer.BuiltinTypesSerializer.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_UInt32_Writer_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer>.NativeClassPtr, 100663505);
				BinaryStorageBuffer.BuiltinTypesSerializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer>.NativeClassPtr, 100663506);
			}

			// Token: 0x170001CB RID: 459
			// (get) Token: 0x060005BE RID: 1470 RVA: 0x0001B9E8 File Offset: 0x00019BE8
			public unsafe virtual IEnumerable<BinaryStorageBuffer.ISerializationAdapter> Dependencies
			{
				[CallerCount(74)]
				[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.BuiltinTypesSerializer.NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IEnumerable_1_ISerializationAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<BinaryStorageBuffer.ISerializationAdapter>>(intPtr3) : null;
				}
			}

			// Token: 0x060005BF RID: 1471 RVA: 0x0001BA28 File Offset: 0x00019C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137466, XrefRangeEnd = 1137515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Deserialize(BinaryStorageBuffer.Reader reader, Type t, uint offset)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.BuiltinTypesSerializer.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Reader_Type_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060005C0 RID: 1472 RVA: 0x0001BA98 File Offset: 0x00019C98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137515, XrefRangeEnd = 1137531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe char FindBestSeparator(string str, [Optional] Il2CppStructArray<char> seps)
			{
				if (seps == null)
				{
					seps = new Il2CppStructArray<char>(0L);
				}
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(seps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.BuiltinTypesSerializer.NativeMethodInfoPtr_FindBestSeparator_Private_Char_String_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005C1 RID: 1473 RVA: 0x0001BB04 File Offset: 0x00019D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137531, XrefRangeEnd = 1137575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual uint Serialize(BinaryStorageBuffer.Writer writer, Object val)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.BuiltinTypesSerializer.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_UInt32_Writer_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005C2 RID: 1474 RVA: 0x0001BB64 File Offset: 0x00019D64
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BuiltinTypesSerializer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.BuiltinTypesSerializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005C3 RID: 1475 RVA: 0x000042DF File Offset: 0x000024DF
			public char FindBestSeparator(string str, params char[] seps)
			{
				return this.FindBestSeparator(str, new Il2CppStructArray<char>(seps));
			}

			// Token: 0x060005C4 RID: 1476 RVA: 0x000042EE File Offset: 0x000024EE
			public BuiltinTypesSerializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000415 RID: 1045
			private static readonly IntPtr NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IEnumerable_1_ISerializationAdapter_0;

			// Token: 0x04000416 RID: 1046
			private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Reader_Type_UInt32_0;

			// Token: 0x04000417 RID: 1047
			private static readonly IntPtr NativeMethodInfoPtr_FindBestSeparator_Private_Char_String_Il2CppStructArray_1_Char_0;

			// Token: 0x04000418 RID: 1048
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_UInt32_Writer_Object_0;

			// Token: 0x04000419 RID: 1049
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200009A RID: 154
			[StructLayout(2)]
			public struct ObjectToStringRemap
			{
				// Token: 0x0600070E RID: 1806 RVA: 0x0002095C File Offset: 0x0001EB5C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectToStringRemap()
				{
					Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer.ObjectToStringRemap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer>.NativeClassPtr, "ObjectToStringRemap");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer.ObjectToStringRemap>.NativeClassPtr);
					BinaryStorageBuffer.BuiltinTypesSerializer.ObjectToStringRemap.NativeFieldInfoPtr_stringId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer.ObjectToStringRemap>.NativeClassPtr, "stringId");
					BinaryStorageBuffer.BuiltinTypesSerializer.ObjectToStringRemap.NativeFieldInfoPtr_separator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer.ObjectToStringRemap>.NativeClassPtr, "separator");
				}

				// Token: 0x0600070F RID: 1807 RVA: 0x00004C2A File Offset: 0x00002E2A
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer.ObjectToStringRemap>.NativeClassPtr, ref this));
				}

				// Token: 0x040004F9 RID: 1273
				private static readonly IntPtr NativeFieldInfoPtr_stringId;

				// Token: 0x040004FA RID: 1274
				private static readonly IntPtr NativeFieldInfoPtr_separator;

				// Token: 0x040004FB RID: 1275
				[FieldOffset(0)]
				public uint stringId;

				// Token: 0x040004FC RID: 1276
				[FieldOffset(4)]
				public char separator;
			}

			// Token: 0x0200009B RID: 155
			[ObfuscatedName("UnityEngine.ResourceManagement.Util.BinaryStorageBuffer+BuiltinTypesSerializer+<>c__DisplayClass4_0")]
			public sealed class __c__DisplayClass4_0 : Object
			{
				// Token: 0x06000710 RID: 1808 RVA: 0x000209B0 File Offset: 0x0001EBB0
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass4_0()
				{
					Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer>.NativeClassPtr, "<>c__DisplayClass4_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer.__c__DisplayClass4_0>.NativeClassPtr);
					BinaryStorageBuffer.BuiltinTypesSerializer.__c__DisplayClass4_0.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer.__c__DisplayClass4_0>.NativeClassPtr, "s");
					BinaryStorageBuffer.BuiltinTypesSerializer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer.__c__DisplayClass4_0>.NativeClassPtr, 100663507);
					BinaryStorageBuffer.BuiltinTypesSerializer.__c__DisplayClass4_0.NativeMethodInfoPtr__FindBestSeparator_b__0_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer.__c__DisplayClass4_0>.NativeClassPtr, 100663508);
				}

				// Token: 0x06000711 RID: 1809 RVA: 0x00020A18 File Offset: 0x0001EC18
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass4_0()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryStorageBuffer.BuiltinTypesSerializer.__c__DisplayClass4_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.BuiltinTypesSerializer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06000712 RID: 1810 RVA: 0x00020A54 File Offset: 0x0001EC54
				[CallerCount(0)]
				public unsafe bool _FindBestSeparator_b__0(char c)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref c;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.BuiltinTypesSerializer.__c__DisplayClass4_0.NativeMethodInfoPtr__FindBestSeparator_b__0_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06000713 RID: 1811 RVA: 0x00004C3C File Offset: 0x00002E3C
				public __c__DisplayClass4_0(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000212 RID: 530
				// (get) Token: 0x06000714 RID: 1812 RVA: 0x00020AA0 File Offset: 0x0001ECA0
				// (set) Token: 0x06000715 RID: 1813 RVA: 0x00004C45 File Offset: 0x00002E45
				public unsafe char s
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.BuiltinTypesSerializer.__c__DisplayClass4_0.NativeFieldInfoPtr_s);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.BuiltinTypesSerializer.__c__DisplayClass4_0.NativeFieldInfoPtr_s)) = value;
					}
				}

				// Token: 0x040004FD RID: 1277
				private static readonly IntPtr NativeFieldInfoPtr_s;

				// Token: 0x040004FE RID: 1278
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x040004FF RID: 1279
				private static readonly IntPtr NativeMethodInfoPtr__FindBestSeparator_b__0_Internal_Boolean_Char_0;
			}
		}

		// Token: 0x02000072 RID: 114
		public class TypeSerializer : Object
		{
			// Token: 0x060005C5 RID: 1477 RVA: 0x0001BBA0 File Offset: 0x00019DA0
			// Note: this type is marked as 'beforefieldinit'.
			static TypeSerializer()
			{
				Il2CppClassPointerStore<BinaryStorageBuffer.TypeSerializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, "TypeSerializer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryStorageBuffer.TypeSerializer>.NativeClassPtr);
				BinaryStorageBuffer.TypeSerializer.NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IEnumerable_1_ISerializationAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.TypeSerializer>.NativeClassPtr, 100663509);
				BinaryStorageBuffer.TypeSerializer.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Reader_Type_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.TypeSerializer>.NativeClassPtr, 100663510);
				BinaryStorageBuffer.TypeSerializer.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_UInt32_Writer_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.TypeSerializer>.NativeClassPtr, 100663511);
				BinaryStorageBuffer.TypeSerializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.TypeSerializer>.NativeClassPtr, 100663512);
			}

			// Token: 0x170001CC RID: 460
			// (get) Token: 0x060005C6 RID: 1478 RVA: 0x0001BC1C File Offset: 0x00019E1C
			public unsafe virtual IEnumerable<BinaryStorageBuffer.ISerializationAdapter> Dependencies
			{
				[CallerCount(74)]
				[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.TypeSerializer.NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IEnumerable_1_ISerializationAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<BinaryStorageBuffer.ISerializationAdapter>>(intPtr3) : null;
				}
			}

			// Token: 0x060005C7 RID: 1479 RVA: 0x0001BC5C File Offset: 0x00019E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137575, XrefRangeEnd = 1137588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual Object Deserialize(BinaryStorageBuffer.Reader reader, Type type, uint offset)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.TypeSerializer.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Reader_Type_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060005C8 RID: 1480 RVA: 0x0001BCCC File Offset: 0x00019ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137588, XrefRangeEnd = 1137596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual uint Serialize(BinaryStorageBuffer.Writer writer, Object val)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.TypeSerializer.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_UInt32_Writer_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005C9 RID: 1481 RVA: 0x0001BD2C File Offset: 0x00019F2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TypeSerializer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryStorageBuffer.TypeSerializer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.TypeSerializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005CA RID: 1482 RVA: 0x000042F7 File Offset: 0x000024F7
			public TypeSerializer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400041A RID: 1050
			private static readonly IntPtr NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IEnumerable_1_ISerializationAdapter_0;

			// Token: 0x0400041B RID: 1051
			private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Reader_Type_UInt32_0;

			// Token: 0x0400041C RID: 1052
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_UInt32_Writer_Object_0;

			// Token: 0x0400041D RID: 1053
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0200009C RID: 156
			[StructLayout(2)]
			public struct Data
			{
				// Token: 0x06000716 RID: 1814 RVA: 0x00020AC8 File Offset: 0x0001ECC8
				// Note: this type is marked as 'beforefieldinit'.
				static Data()
				{
					Il2CppClassPointerStore<BinaryStorageBuffer.TypeSerializer.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryStorageBuffer.TypeSerializer>.NativeClassPtr, "Data");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryStorageBuffer.TypeSerializer.Data>.NativeClassPtr);
					BinaryStorageBuffer.TypeSerializer.Data.NativeFieldInfoPtr_assemblyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.TypeSerializer.Data>.NativeClassPtr, "assemblyId");
					BinaryStorageBuffer.TypeSerializer.Data.NativeFieldInfoPtr_classId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.TypeSerializer.Data>.NativeClassPtr, "classId");
				}

				// Token: 0x06000717 RID: 1815 RVA: 0x00004C60 File Offset: 0x00002E60
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BinaryStorageBuffer.TypeSerializer.Data>.NativeClassPtr, ref this));
				}

				// Token: 0x04000500 RID: 1280
				private static readonly IntPtr NativeFieldInfoPtr_assemblyId;

				// Token: 0x04000501 RID: 1281
				private static readonly IntPtr NativeFieldInfoPtr_classId;

				// Token: 0x04000502 RID: 1282
				[FieldOffset(0)]
				public uint assemblyId;

				// Token: 0x04000503 RID: 1283
				[FieldOffset(4)]
				public uint classId;
			}
		}

		// Token: 0x02000073 RID: 115
		[StructLayout(2)]
		public struct DynamicString
		{
			// Token: 0x060005CB RID: 1483 RVA: 0x0001BD68 File Offset: 0x00019F68
			// Note: this type is marked as 'beforefieldinit'.
			static DynamicString()
			{
				Il2CppClassPointerStore<BinaryStorageBuffer.DynamicString>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, "DynamicString");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryStorageBuffer.DynamicString>.NativeClassPtr);
				BinaryStorageBuffer.DynamicString.NativeFieldInfoPtr_stringId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.DynamicString>.NativeClassPtr, "stringId");
				BinaryStorageBuffer.DynamicString.NativeFieldInfoPtr_nextId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.DynamicString>.NativeClassPtr, "nextId");
			}

			// Token: 0x060005CC RID: 1484 RVA: 0x00004300 File Offset: 0x00002500
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BinaryStorageBuffer.DynamicString>.NativeClassPtr, ref this));
			}

			// Token: 0x0400041E RID: 1054
			private static readonly IntPtr NativeFieldInfoPtr_stringId;

			// Token: 0x0400041F RID: 1055
			private static readonly IntPtr NativeFieldInfoPtr_nextId;

			// Token: 0x04000420 RID: 1056
			[FieldOffset(0)]
			public uint stringId;

			// Token: 0x04000421 RID: 1057
			[FieldOffset(4)]
			public uint nextId;
		}

		// Token: 0x02000074 RID: 116
		[StructLayout(2)]
		public struct ObjectTypeData
		{
			// Token: 0x060005CD RID: 1485 RVA: 0x0001BDBC File Offset: 0x00019FBC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectTypeData()
			{
				Il2CppClassPointerStore<BinaryStorageBuffer.ObjectTypeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, "ObjectTypeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryStorageBuffer.ObjectTypeData>.NativeClassPtr);
				BinaryStorageBuffer.ObjectTypeData.NativeFieldInfoPtr_typeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.ObjectTypeData>.NativeClassPtr, "typeId");
				BinaryStorageBuffer.ObjectTypeData.NativeFieldInfoPtr_objectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.ObjectTypeData>.NativeClassPtr, "objectId");
			}

			// Token: 0x060005CE RID: 1486 RVA: 0x00004312 File Offset: 0x00002512
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BinaryStorageBuffer.ObjectTypeData>.NativeClassPtr, ref this));
			}

			// Token: 0x04000422 RID: 1058
			private static readonly IntPtr NativeFieldInfoPtr_typeId;

			// Token: 0x04000423 RID: 1059
			private static readonly IntPtr NativeFieldInfoPtr_objectId;

			// Token: 0x04000424 RID: 1060
			[FieldOffset(0)]
			public uint typeId;

			// Token: 0x04000425 RID: 1061
			[FieldOffset(4)]
			public uint objectId;
		}

		// Token: 0x02000075 RID: 117
		public class ISerializationAdapter : Il2CppObjectBase
		{
			// Token: 0x060005CF RID: 1487 RVA: 0x0001BE10 File Offset: 0x0001A010
			// Note: this type is marked as 'beforefieldinit'.
			static ISerializationAdapter()
			{
				Il2CppClassPointerStore<BinaryStorageBuffer.ISerializationAdapter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, "ISerializationAdapter");
				BinaryStorageBuffer.ISerializationAdapter.NativeMethodInfoPtr_get_Dependencies_Public_Abstract_Virtual_New_get_IEnumerable_1_ISerializationAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.ISerializationAdapter>.NativeClassPtr, 100663513);
				BinaryStorageBuffer.ISerializationAdapter.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_UInt32_Writer_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.ISerializationAdapter>.NativeClassPtr, 100663514);
				BinaryStorageBuffer.ISerializationAdapter.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Object_Reader_Type_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.ISerializationAdapter>.NativeClassPtr, 100663515);
			}

			// Token: 0x170001CD RID: 461
			// (get) Token: 0x060005D0 RID: 1488 RVA: 0x0001BE70 File Offset: 0x0001A070
			public unsafe virtual IEnumerable<BinaryStorageBuffer.ISerializationAdapter> Dependencies
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryStorageBuffer.ISerializationAdapter.NativeMethodInfoPtr_get_Dependencies_Public_Abstract_Virtual_New_get_IEnumerable_1_ISerializationAdapter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<BinaryStorageBuffer.ISerializationAdapter>>(intPtr3) : null;
				}
			}

			// Token: 0x060005D1 RID: 1489 RVA: 0x0001BEBC File Offset: 0x0001A0BC
			[CallerCount(0)]
			public unsafe virtual uint Serialize(BinaryStorageBuffer.Writer writer, Object val)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryStorageBuffer.ISerializationAdapter.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_UInt32_Writer_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005D2 RID: 1490 RVA: 0x0001BF28 File Offset: 0x0001A128
			[CallerCount(0)]
			public unsafe virtual Object Deserialize(BinaryStorageBuffer.Reader reader, Type t, uint offset)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BinaryStorageBuffer.ISerializationAdapter.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Object_Reader_Type_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060005D3 RID: 1491 RVA: 0x00004324 File Offset: 0x00002524
			public ISerializationAdapter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000426 RID: 1062
			private static readonly IntPtr NativeMethodInfoPtr_get_Dependencies_Public_Abstract_Virtual_New_get_IEnumerable_1_ISerializationAdapter_0;

			// Token: 0x04000427 RID: 1063
			private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_UInt32_Writer_Object_0;

			// Token: 0x04000428 RID: 1064
			private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Object_Reader_Type_UInt32_0;
		}

		// Token: 0x02000076 RID: 118
		public class ISerializationAdapter<T> : Il2CppObjectBase
		{
			// Token: 0x060005D4 RID: 1492 RVA: 0x0001BFA4 File Offset: 0x0001A1A4
			// Note: this type is marked as 'beforefieldinit'.
			static ISerializationAdapter()
			{
				Il2CppClassPointerStore<BinaryStorageBuffer.ISerializationAdapter<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, "ISerializationAdapter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			}

			// Token: 0x060005D5 RID: 1493 RVA: 0x0000432D File Offset: 0x0000252D
			public ISerializationAdapter(IntPtr pointer)
				: base(pointer)
			{
			}
		}

		// Token: 0x02000077 RID: 119
		public class Reader : Object
		{
			// Token: 0x060005D6 RID: 1494 RVA: 0x0001C000 File Offset: 0x0001A200
			// Note: this type is marked as 'beforefieldinit'.
			static Reader()
			{
				Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, "Reader");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr);
				BinaryStorageBuffer.Reader.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, "m_Buffer");
				BinaryStorageBuffer.Reader.NativeFieldInfoPtr_m_Adapters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, "m_Adapters");
				BinaryStorageBuffer.Reader.NativeFieldInfoPtr_m_Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, "m_Cache");
				BinaryStorageBuffer.Reader.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, "stringBuilder");
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_Init_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppReferenceArray_1_ISerializationAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663516);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_AddSerializationAdapter_Public_Void_ISerializationAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663517);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Il2CppReferenceArray_1_ISerializationAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663518);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_GetBuffer_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663519);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr__ctor_Public_Void_Stream_UInt32_Int32_Il2CppReferenceArray_1_ISerializationAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663520);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_TryGetCachedValue_Private_Boolean_UInt32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663521);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadObjectArray_Public_Il2CppReferenceArray_1_Object_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663522);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadObjectArray_Public_Il2CppReferenceArray_1_Object_Type_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663523);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadObjectArray_Public_Il2CppArrayBase_1_T_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663524);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadObject_Public_Object_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663525);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadObject_Public_T_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663526);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadObject_Public_Object_Type_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663527);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadValueArray_Public_Il2CppArrayBase_1_T_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663528);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadValue_Public_T_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663529);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadString_Public_String_UInt32_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663530);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadStringInternal_Private_String_UInt32_Encoding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663531);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadAutoEncodedString_Private_String_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663532);
				BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadDynamicString_Private_String_UInt32_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr, 100663533);
			}

			// Token: 0x060005D7 RID: 1495 RVA: 0x0001C1E4 File Offset: 0x0001A3E4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1137627, RefRangeEnd = 1137629, XrefRangeStart = 1137596, XrefRangeEnd = 1137627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(Il2CppStructArray<byte> data, int maxCachedObjects, [Optional] Il2CppReferenceArray<BinaryStorageBuffer.ISerializationAdapter> adapters)
			{
				if (adapters == null)
				{
					adapters = new Il2CppReferenceArray<BinaryStorageBuffer.ISerializationAdapter>(0L);
				}
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCachedObjects;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adapters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_Init_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppReferenceArray_1_ISerializationAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005D8 RID: 1496 RVA: 0x0001C254 File Offset: 0x0001A454
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137629, XrefRangeEnd = 1137630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddSerializationAdapter(BinaryStorageBuffer.ISerializationAdapter a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_AddSerializationAdapter_Public_Void_ISerializationAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060005D9 RID: 1497 RVA: 0x0001C298 File Offset: 0x0001A498
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1137632, RefRangeEnd = 1137633, XrefRangeStart = 1137630, XrefRangeEnd = 1137632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Reader(Il2CppStructArray<byte> data, int maxCachedObjects = 1024, [Optional] Il2CppReferenceArray<BinaryStorageBuffer.ISerializationAdapter> adapters)
			{
				if (adapters == null)
				{
					adapters = new Il2CppReferenceArray<BinaryStorageBuffer.ISerializationAdapter>(0L);
				}
				this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr));
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCachedObjects;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adapters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Il2CppReferenceArray_1_ISerializationAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005DA RID: 1498 RVA: 0x0001C310 File Offset: 0x0001A510
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> GetBuffer()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_GetBuffer_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}

			// Token: 0x060005DB RID: 1499 RVA: 0x0001C350 File Offset: 0x0001A550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137633, XrefRangeEnd = 1137641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Reader(Stream inputStream, uint bufferSize, int maxCachedObjects, [Optional] Il2CppReferenceArray<BinaryStorageBuffer.ISerializationAdapter> adapters)
			{
				if (adapters == null)
				{
					adapters = new Il2CppReferenceArray<BinaryStorageBuffer.ISerializationAdapter>(0L);
				}
				this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr));
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputStream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCachedObjects;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adapters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.NativeMethodInfoPtr__ctor_Public_Void_Stream_UInt32_Int32_Il2CppReferenceArray_1_ISerializationAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005DC RID: 1500 RVA: 0x0001C3D8 File Offset: 0x0001A5D8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1137645, RefRangeEnd = 1137648, XrefRangeStart = 1137641, XrefRangeEnd = 1137645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool TryGetCachedValue<T>(uint offset, out T val)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref val;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.MethodInfoStoreGeneric_TryGetCachedValue_Private_Boolean_UInt32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					val = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}

			// Token: 0x060005DD RID: 1501 RVA: 0x0001C470 File Offset: 0x0001A670
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137648, XrefRangeEnd = 1137665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Object> ReadObjectArray(uint id, bool cacheValues = true)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheValues;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadObjectArray_Public_Il2CppReferenceArray_1_Object_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}

			// Token: 0x060005DE RID: 1502 RVA: 0x0001C4CC File Offset: 0x0001A6CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137665, XrefRangeEnd = 1137675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppReferenceArray<Object> ReadObjectArray(Type t, uint id, bool cacheValues = true)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheValues;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadObjectArray_Public_Il2CppReferenceArray_1_Object_Type_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}

			// Token: 0x060005DF RID: 1503 RVA: 0x0001C538 File Offset: 0x0001A738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137675, XrefRangeEnd = 1137687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppArrayBase<T> ReadObjectArray<T>(uint id, bool cacheValues = true)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheValues;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.MethodInfoStoreGeneric_ReadObjectArray_Public_Il2CppArrayBase_1_T_UInt32_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}

			// Token: 0x060005E0 RID: 1504 RVA: 0x0001C58C File Offset: 0x0001A78C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137687, XrefRangeEnd = 1137694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ReadObject(uint id, bool cacheValue = true)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadObject_Public_Object_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060005E1 RID: 1505 RVA: 0x0001C5E8 File Offset: 0x0001A7E8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1137702, RefRangeEnd = 1137704, XrefRangeStart = 1137694, XrefRangeEnd = 1137702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T ReadObject<T>(uint offset, bool cacheValue = true)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.MethodInfoStoreGeneric_ReadObject_Public_T_UInt32_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}

			// Token: 0x060005E2 RID: 1506 RVA: 0x0001C63C File Offset: 0x0001A83C
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1137719, RefRangeEnd = 1137724, XrefRangeStart = 1137704, XrefRangeEnd = 1137719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ReadObject(Type t, uint id, bool cacheValue = true)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadObject_Public_Object_Type_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x060005E3 RID: 1507 RVA: 0x0001C6A8 File Offset: 0x0001A8A8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1137736, RefRangeEnd = 1137739, XrefRangeStart = 1137724, XrefRangeEnd = 1137736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppArrayBase<T> ReadValueArray<T>(uint id, bool cacheValue = true) where T : new()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.MethodInfoStoreGeneric_ReadValueArray_Public_Il2CppArrayBase_1_T_UInt32_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}

			// Token: 0x060005E4 RID: 1508 RVA: 0x0001C6FC File Offset: 0x0001A8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137739, XrefRangeEnd = 1137741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T ReadValue<T>(uint id) where T : new()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.MethodInfoStoreGeneric_ReadValue_Public_T_UInt32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060005E5 RID: 1509 RVA: 0x0001C744 File Offset: 0x0001A944
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1137746, RefRangeEnd = 1137747, XrefRangeStart = 1137741, XrefRangeEnd = 1137746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string ReadString(uint id, char sep = '\0', bool cacheValue = true)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sep;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadString_Public_String_UInt32_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060005E6 RID: 1510 RVA: 0x0001C7A4 File Offset: 0x0001A9A4
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1137755, RefRangeEnd = 1137760, XrefRangeStart = 1137747, XrefRangeEnd = 1137755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string ReadStringInternal(uint offset, Encoding enc, bool cacheValue = true)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadStringInternal_Private_String_UInt32_Encoding_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060005E7 RID: 1511 RVA: 0x0001C808 File Offset: 0x0001AA08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137760, XrefRangeEnd = 1137764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string ReadAutoEncodedString(uint id, bool cacheValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadAutoEncodedString_Private_String_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060005E8 RID: 1512 RVA: 0x0001C85C File Offset: 0x0001AA5C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1137792, RefRangeEnd = 1137795, XrefRangeStart = 1137764, XrefRangeEnd = 1137792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string ReadDynamicString(uint id, char sep, bool cacheValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sep;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cacheValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadDynamicString_Private_String_UInt32_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060005E9 RID: 1513 RVA: 0x00004336 File Offset: 0x00002536
			public void Init(Il2CppStructArray<byte> data, int maxCachedObjects, params BinaryStorageBuffer.ISerializationAdapter[] adapters)
			{
				this.Init(data, maxCachedObjects, new Il2CppReferenceArray<BinaryStorageBuffer.ISerializationAdapter>(adapters));
			}

			// Token: 0x060005EA RID: 1514 RVA: 0x00004346 File Offset: 0x00002546
			public Reader(Il2CppStructArray<byte> data, [Optional] int maxCachedObjects, params BinaryStorageBuffer.ISerializationAdapter[] adapters)
				: this(data, maxCachedObjects, new Il2CppReferenceArray<BinaryStorageBuffer.ISerializationAdapter>(adapters))
			{
			}

			// Token: 0x060005EB RID: 1515 RVA: 0x00004356 File Offset: 0x00002556
			public Reader(Stream inputStream, uint bufferSize, int maxCachedObjects, params BinaryStorageBuffer.ISerializationAdapter[] adapters)
				: this(inputStream, bufferSize, maxCachedObjects, new Il2CppReferenceArray<BinaryStorageBuffer.ISerializationAdapter>(adapters))
			{
			}

			// Token: 0x060005EC RID: 1516 RVA: 0x00004368 File Offset: 0x00002568
			public Reader(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001CE RID: 462
			// (get) Token: 0x060005ED RID: 1517 RVA: 0x0001C8BC File Offset: 0x0001AABC
			// (set) Token: 0x060005EE RID: 1518 RVA: 0x00004371 File Offset: 0x00002571
			public unsafe Il2CppStructArray<byte> m_Buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Reader.NativeFieldInfoPtr_m_Buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Reader.NativeFieldInfoPtr_m_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001CF RID: 463
			// (get) Token: 0x060005EF RID: 1519 RVA: 0x0001C8EC File Offset: 0x0001AAEC
			// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00004390 File Offset: 0x00002590
			public unsafe Dictionary<Type, BinaryStorageBuffer.ISerializationAdapter> m_Adapters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Reader.NativeFieldInfoPtr_m_Adapters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, BinaryStorageBuffer.ISerializationAdapter>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Reader.NativeFieldInfoPtr_m_Adapters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D0 RID: 464
			// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001C91C File Offset: 0x0001AB1C
			// (set) Token: 0x060005F2 RID: 1522 RVA: 0x000043AF File Offset: 0x000025AF
			public LRUCache<uint, Object> m_Cache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Reader.NativeFieldInfoPtr_m_Cache);
					return new LRUCache<uint, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LRUCache<uint, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Reader.NativeFieldInfoPtr_m_Cache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LRUCache<uint, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170001D1 RID: 465
			// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0001C94C File Offset: 0x0001AB4C
			// (set) Token: 0x060005F4 RID: 1524 RVA: 0x000043DD File Offset: 0x000025DD
			public unsafe StringBuilder stringBuilder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Reader.NativeFieldInfoPtr_stringBuilder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Reader.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000429 RID: 1065
			private static readonly IntPtr NativeFieldInfoPtr_m_Buffer;

			// Token: 0x0400042A RID: 1066
			private static readonly IntPtr NativeFieldInfoPtr_m_Adapters;

			// Token: 0x0400042B RID: 1067
			private static readonly IntPtr NativeFieldInfoPtr_m_Cache;

			// Token: 0x0400042C RID: 1068
			private static readonly IntPtr NativeFieldInfoPtr_stringBuilder;

			// Token: 0x0400042D RID: 1069
			private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppReferenceArray_1_ISerializationAdapter_0;

			// Token: 0x0400042E RID: 1070
			private static readonly IntPtr NativeMethodInfoPtr_AddSerializationAdapter_Public_Void_ISerializationAdapter_0;

			// Token: 0x0400042F RID: 1071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_Int32_Il2CppReferenceArray_1_ISerializationAdapter_0;

			// Token: 0x04000430 RID: 1072
			private static readonly IntPtr NativeMethodInfoPtr_GetBuffer_Internal_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000431 RID: 1073
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_UInt32_Int32_Il2CppReferenceArray_1_ISerializationAdapter_0;

			// Token: 0x04000432 RID: 1074
			private static readonly IntPtr NativeMethodInfoPtr_TryGetCachedValue_Private_Boolean_UInt32_byref_T_0;

			// Token: 0x04000433 RID: 1075
			private static readonly IntPtr NativeMethodInfoPtr_ReadObjectArray_Public_Il2CppReferenceArray_1_Object_UInt32_Boolean_0;

			// Token: 0x04000434 RID: 1076
			private static readonly IntPtr NativeMethodInfoPtr_ReadObjectArray_Public_Il2CppReferenceArray_1_Object_Type_UInt32_Boolean_0;

			// Token: 0x04000435 RID: 1077
			private static readonly IntPtr NativeMethodInfoPtr_ReadObjectArray_Public_Il2CppArrayBase_1_T_UInt32_Boolean_0;

			// Token: 0x04000436 RID: 1078
			private static readonly IntPtr NativeMethodInfoPtr_ReadObject_Public_Object_UInt32_Boolean_0;

			// Token: 0x04000437 RID: 1079
			private static readonly IntPtr NativeMethodInfoPtr_ReadObject_Public_T_UInt32_Boolean_0;

			// Token: 0x04000438 RID: 1080
			private static readonly IntPtr NativeMethodInfoPtr_ReadObject_Public_Object_Type_UInt32_Boolean_0;

			// Token: 0x04000439 RID: 1081
			private static readonly IntPtr NativeMethodInfoPtr_ReadValueArray_Public_Il2CppArrayBase_1_T_UInt32_Boolean_0;

			// Token: 0x0400043A RID: 1082
			private static readonly IntPtr NativeMethodInfoPtr_ReadValue_Public_T_UInt32_0;

			// Token: 0x0400043B RID: 1083
			private static readonly IntPtr NativeMethodInfoPtr_ReadString_Public_String_UInt32_Char_Boolean_0;

			// Token: 0x0400043C RID: 1084
			private static readonly IntPtr NativeMethodInfoPtr_ReadStringInternal_Private_String_UInt32_Encoding_Boolean_0;

			// Token: 0x0400043D RID: 1085
			private static readonly IntPtr NativeMethodInfoPtr_ReadAutoEncodedString_Private_String_UInt32_Boolean_0;

			// Token: 0x0400043E RID: 1086
			private static readonly IntPtr NativeMethodInfoPtr_ReadDynamicString_Private_String_UInt32_Char_Boolean_0;

			// Token: 0x0200009D RID: 157
			private sealed class MethodInfoStoreGeneric_TryGetCachedValue_Private_Boolean_UInt32_byref_T_0<T>
			{
				// Token: 0x04000504 RID: 1284
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_TryGetCachedValue_Private_Boolean_UInt32_byref_T_0, Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x0200009E RID: 158
			private sealed class MethodInfoStoreGeneric_ReadObjectArray_Public_Il2CppArrayBase_1_T_UInt32_Boolean_0<T>
			{
				// Token: 0x04000505 RID: 1285
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadObjectArray_Public_Il2CppArrayBase_1_T_UInt32_Boolean_0, Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x0200009F RID: 159
			private sealed class MethodInfoStoreGeneric_ReadObject_Public_T_UInt32_Boolean_0<T>
			{
				// Token: 0x04000506 RID: 1286
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadObject_Public_T_UInt32_Boolean_0, Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020000A0 RID: 160
			private sealed class MethodInfoStoreGeneric_ReadValueArray_Public_Il2CppArrayBase_1_T_UInt32_Boolean_0<T>
			{
				// Token: 0x04000507 RID: 1287
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadValueArray_Public_Il2CppArrayBase_1_T_UInt32_Boolean_0, Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020000A1 RID: 161
			private sealed class MethodInfoStoreGeneric_ReadValue_Public_T_UInt32_0<T>
			{
				// Token: 0x04000508 RID: 1288
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Reader.NativeMethodInfoPtr_ReadValue_Public_T_UInt32_0, Il2CppClassPointerStore<BinaryStorageBuffer.Reader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000078 RID: 120
		public class Writer : Object
		{
			// Token: 0x060005F5 RID: 1525 RVA: 0x0001C97C File Offset: 0x0001AB7C
			// Note: this type is marked as 'beforefieldinit'.
			static Writer()
			{
				Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryStorageBuffer>.NativeClassPtr, "Writer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr);
				BinaryStorageBuffer.Writer.NativeFieldInfoPtr_totalBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, "totalBytes");
				BinaryStorageBuffer.Writer.NativeFieldInfoPtr_defaulChunkSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, "defaulChunkSize");
				BinaryStorageBuffer.Writer.NativeFieldInfoPtr_chunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, "chunks");
				BinaryStorageBuffer.Writer.NativeFieldInfoPtr_existingValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, "existingValues");
				BinaryStorageBuffer.Writer.NativeFieldInfoPtr_serializationAdapters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, "serializationAdapters");
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_get_Length_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663534);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppReferenceArray_1_ISerializationAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663535);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_FindChunkWithSpace_Private_Chunk_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663536);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteInternal_Private_UInt32_ptr_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663537);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_ReserveInternal_Private_UInt32_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663538);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteInternal_Private_Void_UInt32_ptr_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663539);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Reserve_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663540);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Write_Public_UInt32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663541);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Write_Public_UInt32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663542);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Write_Public_UInt32_UInt32_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663543);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Write_Public_UInt32_UInt32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663544);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Reserve_Public_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663545);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Write_Public_UInt32_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663546);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Write_Public_UInt32_UInt32_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663547);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteObjects_Public_UInt32_IEnumerable_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663548);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteObject_Public_UInt32_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663549);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteString_Public_UInt32_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663550);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteStringInternal_Private_UInt32_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663551);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_SerializeToByteArray_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663552);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_SerializeToStream_Public_UInt32_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663553);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_IsUnicode_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663554);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteAutoEncodedString_Private_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663555);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteUnicodeString_Private_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663556);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_ComputeStringSize_Private_Static_UInt32_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663557);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_RecurseDynamicStringParts_Private_UInt32_Il2CppReferenceArray_1_StringParts_Int32_Char_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663558);
				BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteDynamicString_Private_UInt32_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, 100663559);
			}

			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0001CC14 File Offset: 0x0001AE14
			public unsafe uint Length
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_get_Length_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060005F7 RID: 1527 RVA: 0x0001CC50 File Offset: 0x0001AE50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137795, XrefRangeEnd = 1137838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Writer(int chunkSize = 1048576, [Optional] Il2CppReferenceArray<BinaryStorageBuffer.ISerializationAdapter> adapters)
			{
				if (adapters == null)
				{
					adapters = new Il2CppReferenceArray<BinaryStorageBuffer.ISerializationAdapter>(0L);
				}
				this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr));
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref chunkSize;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adapters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppReferenceArray_1_ISerializationAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005F8 RID: 1528 RVA: 0x0001CCB8 File Offset: 0x0001AEB8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1137856, RefRangeEnd = 1137859, XrefRangeStart = 1137838, XrefRangeEnd = 1137856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BinaryStorageBuffer.Writer.Chunk FindChunkWithSpace(uint length)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref length;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_FindChunkWithSpace_Private_Chunk_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BinaryStorageBuffer.Writer.Chunk>(intPtr3) : null;
				}
			}

			// Token: 0x060005F9 RID: 1529 RVA: 0x0001CD04 File Offset: 0x0001AF04
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1137867, RefRangeEnd = 1137872, XrefRangeStart = 1137859, XrefRangeEnd = 1137867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint WriteInternal(void* pData, uint dataSize, bool prefixSize)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = pData;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataSize;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prefixSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteInternal_Private_UInt32_ptr_Void_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005FA RID: 1530 RVA: 0x0001CD68 File Offset: 0x0001AF68
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1137873, RefRangeEnd = 1137875, XrefRangeStart = 1137872, XrefRangeEnd = 1137873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint ReserveInternal(uint dataSize, bool prefixSize)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dataSize;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prefixSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_ReserveInternal_Private_UInt32_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005FB RID: 1531 RVA: 0x0001CDC0 File Offset: 0x0001AFC0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1137899, RefRangeEnd = 1137901, XrefRangeStart = 1137875, XrefRangeEnd = 1137899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WriteInternal(uint id, void* pData, uint dataSize, bool prefixSize)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = pData;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataSize;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prefixSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteInternal_Private_Void_UInt32_ptr_Void_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060005FC RID: 1532 RVA: 0x0001CE28 File Offset: 0x0001B028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137901, XrefRangeEnd = 1137903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint Reserve<T>() where T : new()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.MethodInfoStoreGeneric_Reserve_Public_UInt32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060005FD RID: 1533 RVA: 0x0001CE64 File Offset: 0x0001B064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137903, XrefRangeEnd = 1137905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint Write<T>([In] ref T val) where T : new()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(val);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.MethodInfoStoreGeneric_Write_Public_UInt32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					val = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x060005FE RID: 1534 RVA: 0x0001CECC File Offset: 0x0001B0CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137905, XrefRangeEnd = 1137906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint Write<T>(T val) where T : new()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = val;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref val;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.MethodInfoStoreGeneric_Write_Public_UInt32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			// Token: 0x060005FF RID: 1535 RVA: 0x0001CF50 File Offset: 0x0001B150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137906, XrefRangeEnd = 1137908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint Write<T>(uint offset, [In] ref T val) where T : new()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(val);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.MethodInfoStoreGeneric_Write_Public_UInt32_UInt32_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				val = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06000600 RID: 1536 RVA: 0x0001CFC4 File Offset: 0x0001B1C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137908, XrefRangeEnd = 1137910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint Write<T>(uint offset, T val) where T : new()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = val;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref val;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.MethodInfoStoreGeneric_Write_Public_UInt32_UInt32_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x06000601 RID: 1537 RVA: 0x0001D058 File Offset: 0x0001B258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137910, XrefRangeEnd = 1137912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint Reserve<T>(uint count) where T : new()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.MethodInfoStoreGeneric_Reserve_Public_UInt32_UInt32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000602 RID: 1538 RVA: 0x0001D0A4 File Offset: 0x0001B2A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1137923, RefRangeEnd = 1137924, XrefRangeStart = 1137912, XrefRangeEnd = 1137923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint Write<T>(Il2CppArrayBase<T> values, bool hashElements = true) where T : new()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashElements;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.MethodInfoStoreGeneric_Write_Public_UInt32_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000603 RID: 1539 RVA: 0x0001D100 File Offset: 0x0001B300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137924, XrefRangeEnd = 1137949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint Write<T>(uint offset, Il2CppArrayBase<T> values, bool hashElements = true) where T : new()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(values);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashElements;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.MethodInfoStoreGeneric_Write_Public_UInt32_UInt32_Il2CppArrayBase_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000604 RID: 1540 RVA: 0x0001D16C File Offset: 0x0001B36C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137949, XrefRangeEnd = 1137981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint WriteObjects<T>(IEnumerable<T> objs, bool serizalizeTypeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serizalizeTypeData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.MethodInfoStoreGeneric_WriteObjects_Public_UInt32_IEnumerable_1_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000605 RID: 1541 RVA: 0x0001D1C8 File Offset: 0x0001B3C8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1137990, RefRangeEnd = 1137992, XrefRangeStart = 1137981, XrefRangeEnd = 1137990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint WriteObject(Object obj, bool serializeTypeData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serializeTypeData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteObject_Public_UInt32_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000606 RID: 1542 RVA: 0x0001D224 File Offset: 0x0001B424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137992, XrefRangeEnd = 1137994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint WriteString(string str, char sep = '\0')
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteString_Public_UInt32_String_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000607 RID: 1543 RVA: 0x0001D280 File Offset: 0x0001B480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137994, XrefRangeEnd = 1137996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint WriteStringInternal(string val, Encoding enc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(val);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteStringInternal_Private_UInt32_String_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000608 RID: 1544 RVA: 0x0001D2E0 File Offset: 0x0001B4E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1137996, XrefRangeEnd = 1138017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> SerializeToByteArray()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_SerializeToByteArray_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}

			// Token: 0x06000609 RID: 1545 RVA: 0x0001D320 File Offset: 0x0001B520
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138017, XrefRangeEnd = 1138031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint SerializeToStream(Stream str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_SerializeToStream_Public_UInt32_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600060A RID: 1546 RVA: 0x0001D370 File Offset: 0x0001B570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138031, XrefRangeEnd = 1138033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsUnicode(string str)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_IsUnicode_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600060B RID: 1547 RVA: 0x0001D3B4 File Offset: 0x0001B5B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1138036, RefRangeEnd = 1138037, XrefRangeStart = 1138033, XrefRangeEnd = 1138036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint WriteAutoEncodedString(string str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteAutoEncodedString_Private_UInt32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600060C RID: 1548 RVA: 0x0001D404 File Offset: 0x0001B604
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1138040, RefRangeEnd = 1138042, XrefRangeStart = 1138037, XrefRangeEnd = 1138040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint WriteUnicodeString(string str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteUnicodeString_Private_UInt32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600060D RID: 1549 RVA: 0x0001D454 File Offset: 0x0001B654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138042, XrefRangeEnd = 1138048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint ComputeStringSize(string str, out bool isUnicode)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isUnicode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_ComputeStringSize_Private_Static_UInt32_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600060E RID: 1550 RVA: 0x0001D4A4 File Offset: 0x0001B6A4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1138069, RefRangeEnd = 1138071, XrefRangeStart = 1138048, XrefRangeEnd = 1138069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint RecurseDynamicStringParts(Il2CppReferenceArray<BinaryStorageBuffer.Writer.StringParts> parts, int index, char sep, uint minSize)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parts);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sep;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_RecurseDynamicStringParts_Private_UInt32_Il2CppReferenceArray_1_StringParts_Int32_Char_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600060F RID: 1551 RVA: 0x0001D51C File Offset: 0x0001B71C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1138084, RefRangeEnd = 1138087, XrefRangeStart = 1138071, XrefRangeEnd = 1138084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint WriteDynamicString(string str, char sep)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteDynamicString_Private_UInt32_String_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000610 RID: 1552 RVA: 0x000043FC File Offset: 0x000025FC
			public Writer([Optional] int chunkSize, params BinaryStorageBuffer.ISerializationAdapter[] adapters)
				: this(chunkSize, new Il2CppReferenceArray<BinaryStorageBuffer.ISerializationAdapter>(adapters))
			{
			}

			// Token: 0x06000611 RID: 1553 RVA: 0x0000440B File Offset: 0x0000260B
			public Writer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001D2 RID: 466
			// (get) Token: 0x06000612 RID: 1554 RVA: 0x0001D578 File Offset: 0x0001B778
			// (set) Token: 0x06000613 RID: 1555 RVA: 0x00004414 File Offset: 0x00002614
			public unsafe uint totalBytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.NativeFieldInfoPtr_totalBytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.NativeFieldInfoPtr_totalBytes)) = value;
				}
			}

			// Token: 0x170001D3 RID: 467
			// (get) Token: 0x06000614 RID: 1556 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
			// (set) Token: 0x06000615 RID: 1557 RVA: 0x0000442F File Offset: 0x0000262F
			public unsafe uint defaulChunkSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.NativeFieldInfoPtr_defaulChunkSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.NativeFieldInfoPtr_defaulChunkSize)) = value;
				}
			}

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
			// (set) Token: 0x06000617 RID: 1559 RVA: 0x0000444A File Offset: 0x0000264A
			public unsafe List<BinaryStorageBuffer.Writer.Chunk> chunks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.NativeFieldInfoPtr_chunks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BinaryStorageBuffer.Writer.Chunk>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.NativeFieldInfoPtr_chunks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x06000618 RID: 1560 RVA: 0x0001D5F8 File Offset: 0x0001B7F8
			// (set) Token: 0x06000619 RID: 1561 RVA: 0x00004469 File Offset: 0x00002669
			public unsafe Dictionary<Hash128, uint> existingValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.NativeFieldInfoPtr_existingValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Hash128, uint>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.NativeFieldInfoPtr_existingValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D6 RID: 470
			// (get) Token: 0x0600061A RID: 1562 RVA: 0x0001D628 File Offset: 0x0001B828
			// (set) Token: 0x0600061B RID: 1563 RVA: 0x00004488 File Offset: 0x00002688
			public unsafe Dictionary<Type, BinaryStorageBuffer.ISerializationAdapter> serializationAdapters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.NativeFieldInfoPtr_serializationAdapters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, BinaryStorageBuffer.ISerializationAdapter>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.NativeFieldInfoPtr_serializationAdapters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400043F RID: 1087
			private static readonly IntPtr NativeFieldInfoPtr_totalBytes;

			// Token: 0x04000440 RID: 1088
			private static readonly IntPtr NativeFieldInfoPtr_defaulChunkSize;

			// Token: 0x04000441 RID: 1089
			private static readonly IntPtr NativeFieldInfoPtr_chunks;

			// Token: 0x04000442 RID: 1090
			private static readonly IntPtr NativeFieldInfoPtr_existingValues;

			// Token: 0x04000443 RID: 1091
			private static readonly IntPtr NativeFieldInfoPtr_serializationAdapters;

			// Token: 0x04000444 RID: 1092
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_UInt32_0;

			// Token: 0x04000445 RID: 1093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Il2CppReferenceArray_1_ISerializationAdapter_0;

			// Token: 0x04000446 RID: 1094
			private static readonly IntPtr NativeMethodInfoPtr_FindChunkWithSpace_Private_Chunk_UInt32_0;

			// Token: 0x04000447 RID: 1095
			private static readonly IntPtr NativeMethodInfoPtr_WriteInternal_Private_UInt32_ptr_Void_UInt32_Boolean_0;

			// Token: 0x04000448 RID: 1096
			private static readonly IntPtr NativeMethodInfoPtr_ReserveInternal_Private_UInt32_UInt32_Boolean_0;

			// Token: 0x04000449 RID: 1097
			private static readonly IntPtr NativeMethodInfoPtr_WriteInternal_Private_Void_UInt32_ptr_Void_UInt32_Boolean_0;

			// Token: 0x0400044A RID: 1098
			private static readonly IntPtr NativeMethodInfoPtr_Reserve_Public_UInt32_0;

			// Token: 0x0400044B RID: 1099
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_UInt32_byref_T_0;

			// Token: 0x0400044C RID: 1100
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_UInt32_T_0;

			// Token: 0x0400044D RID: 1101
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_UInt32_UInt32_byref_T_0;

			// Token: 0x0400044E RID: 1102
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_UInt32_UInt32_T_0;

			// Token: 0x0400044F RID: 1103
			private static readonly IntPtr NativeMethodInfoPtr_Reserve_Public_UInt32_UInt32_0;

			// Token: 0x04000450 RID: 1104
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_UInt32_Il2CppArrayBase_1_T_Boolean_0;

			// Token: 0x04000451 RID: 1105
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_UInt32_UInt32_Il2CppArrayBase_1_T_Boolean_0;

			// Token: 0x04000452 RID: 1106
			private static readonly IntPtr NativeMethodInfoPtr_WriteObjects_Public_UInt32_IEnumerable_1_T_Boolean_0;

			// Token: 0x04000453 RID: 1107
			private static readonly IntPtr NativeMethodInfoPtr_WriteObject_Public_UInt32_Object_Boolean_0;

			// Token: 0x04000454 RID: 1108
			private static readonly IntPtr NativeMethodInfoPtr_WriteString_Public_UInt32_String_Char_0;

			// Token: 0x04000455 RID: 1109
			private static readonly IntPtr NativeMethodInfoPtr_WriteStringInternal_Private_UInt32_String_Encoding_0;

			// Token: 0x04000456 RID: 1110
			private static readonly IntPtr NativeMethodInfoPtr_SerializeToByteArray_Public_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000457 RID: 1111
			private static readonly IntPtr NativeMethodInfoPtr_SerializeToStream_Public_UInt32_Stream_0;

			// Token: 0x04000458 RID: 1112
			private static readonly IntPtr NativeMethodInfoPtr_IsUnicode_Private_Static_Boolean_String_0;

			// Token: 0x04000459 RID: 1113
			private static readonly IntPtr NativeMethodInfoPtr_WriteAutoEncodedString_Private_UInt32_String_0;

			// Token: 0x0400045A RID: 1114
			private static readonly IntPtr NativeMethodInfoPtr_WriteUnicodeString_Private_UInt32_String_0;

			// Token: 0x0400045B RID: 1115
			private static readonly IntPtr NativeMethodInfoPtr_ComputeStringSize_Private_Static_UInt32_String_byref_Boolean_0;

			// Token: 0x0400045C RID: 1116
			private static readonly IntPtr NativeMethodInfoPtr_RecurseDynamicStringParts_Private_UInt32_Il2CppReferenceArray_1_StringParts_Int32_Char_UInt32_0;

			// Token: 0x0400045D RID: 1117
			private static readonly IntPtr NativeMethodInfoPtr_WriteDynamicString_Private_UInt32_String_Char_0;

			// Token: 0x020000A2 RID: 162
			public class Chunk : Object
			{
				// Token: 0x0600071D RID: 1821 RVA: 0x00020CC0 File Offset: 0x0001EEC0
				// Note: this type is marked as 'beforefieldinit'.
				static Chunk()
				{
					Il2CppClassPointerStore<BinaryStorageBuffer.Writer.Chunk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, "Chunk");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryStorageBuffer.Writer.Chunk>.NativeClassPtr);
					BinaryStorageBuffer.Writer.Chunk.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Writer.Chunk>.NativeClassPtr, "position");
					BinaryStorageBuffer.Writer.Chunk.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Writer.Chunk>.NativeClassPtr, "data");
					BinaryStorageBuffer.Writer.Chunk.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryStorageBuffer.Writer.Chunk>.NativeClassPtr, 100663560);
				}

				// Token: 0x0600071E RID: 1822 RVA: 0x00020D28 File Offset: 0x0001EF28
				[CallerCount(2676)]
				[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Chunk()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryStorageBuffer.Writer.Chunk>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryStorageBuffer.Writer.Chunk.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600071F RID: 1823 RVA: 0x00004C72 File Offset: 0x00002E72
				public Chunk(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000213 RID: 531
				// (get) Token: 0x06000720 RID: 1824 RVA: 0x00020D64 File Offset: 0x0001EF64
				// (set) Token: 0x06000721 RID: 1825 RVA: 0x00004C7B File Offset: 0x00002E7B
				public unsafe uint position
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.Chunk.NativeFieldInfoPtr_position);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.Chunk.NativeFieldInfoPtr_position)) = value;
					}
				}

				// Token: 0x17000214 RID: 532
				// (get) Token: 0x06000722 RID: 1826 RVA: 0x00020D8C File Offset: 0x0001EF8C
				// (set) Token: 0x06000723 RID: 1827 RVA: 0x00004C96 File Offset: 0x00002E96
				public unsafe Il2CppStructArray<byte> data
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.Chunk.NativeFieldInfoPtr_data);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.Chunk.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04000509 RID: 1289
				private static readonly IntPtr NativeFieldInfoPtr_position;

				// Token: 0x0400050A RID: 1290
				private static readonly IntPtr NativeFieldInfoPtr_data;

				// Token: 0x0400050B RID: 1291
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}

			// Token: 0x020000A3 RID: 163
			public sealed class StringParts : ValueType
			{
				// Token: 0x06000724 RID: 1828 RVA: 0x00020DBC File Offset: 0x0001EFBC
				// Note: this type is marked as 'beforefieldinit'.
				static StringParts()
				{
					Il2CppClassPointerStore<BinaryStorageBuffer.Writer.StringParts>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr, "StringParts");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryStorageBuffer.Writer.StringParts>.NativeClassPtr);
					BinaryStorageBuffer.Writer.StringParts.NativeFieldInfoPtr_str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Writer.StringParts>.NativeClassPtr, "str");
					BinaryStorageBuffer.Writer.StringParts.NativeFieldInfoPtr_dataSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Writer.StringParts>.NativeClassPtr, "dataSize");
					BinaryStorageBuffer.Writer.StringParts.NativeFieldInfoPtr_isUnicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryStorageBuffer.Writer.StringParts>.NativeClassPtr, "isUnicode");
				}

				// Token: 0x06000725 RID: 1829 RVA: 0x00004CB5 File Offset: 0x00002EB5
				public StringParts(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06000726 RID: 1830 RVA: 0x00004CBE File Offset: 0x00002EBE
				public StringParts()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryStorageBuffer.Writer.StringParts>.NativeClassPtr))
				{
				}

				// Token: 0x17000215 RID: 533
				// (get) Token: 0x06000727 RID: 1831 RVA: 0x00020E24 File Offset: 0x0001F024
				// (set) Token: 0x06000728 RID: 1832 RVA: 0x00004CD0 File Offset: 0x00002ED0
				public unsafe string str
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.StringParts.NativeFieldInfoPtr_str);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.StringParts.NativeFieldInfoPtr_str), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000216 RID: 534
				// (get) Token: 0x06000729 RID: 1833 RVA: 0x00020E4C File Offset: 0x0001F04C
				// (set) Token: 0x0600072A RID: 1834 RVA: 0x00004CEF File Offset: 0x00002EEF
				public unsafe uint dataSize
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.StringParts.NativeFieldInfoPtr_dataSize);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.StringParts.NativeFieldInfoPtr_dataSize)) = value;
					}
				}

				// Token: 0x17000217 RID: 535
				// (get) Token: 0x0600072B RID: 1835 RVA: 0x00020E74 File Offset: 0x0001F074
				// (set) Token: 0x0600072C RID: 1836 RVA: 0x00004D0A File Offset: 0x00002F0A
				public unsafe bool isUnicode
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.StringParts.NativeFieldInfoPtr_isUnicode);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryStorageBuffer.Writer.StringParts.NativeFieldInfoPtr_isUnicode)) = value;
					}
				}

				// Token: 0x0400050C RID: 1292
				private static readonly IntPtr NativeFieldInfoPtr_str;

				// Token: 0x0400050D RID: 1293
				private static readonly IntPtr NativeFieldInfoPtr_dataSize;

				// Token: 0x0400050E RID: 1294
				private static readonly IntPtr NativeFieldInfoPtr_isUnicode;
			}

			// Token: 0x020000A4 RID: 164
			private sealed class MethodInfoStoreGeneric_Reserve_Public_UInt32_0<T>
			{
				// Token: 0x0400050F RID: 1295
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Reserve_Public_UInt32_0, Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020000A5 RID: 165
			private sealed class MethodInfoStoreGeneric_Write_Public_UInt32_byref_T_0<T>
			{
				// Token: 0x04000510 RID: 1296
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Write_Public_UInt32_byref_T_0, Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020000A6 RID: 166
			private sealed class MethodInfoStoreGeneric_Write_Public_UInt32_T_0<T>
			{
				// Token: 0x04000511 RID: 1297
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Write_Public_UInt32_T_0, Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020000A7 RID: 167
			private sealed class MethodInfoStoreGeneric_Write_Public_UInt32_UInt32_byref_T_0<T>
			{
				// Token: 0x04000512 RID: 1298
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Write_Public_UInt32_UInt32_byref_T_0, Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020000A8 RID: 168
			private sealed class MethodInfoStoreGeneric_Write_Public_UInt32_UInt32_T_0<T>
			{
				// Token: 0x04000513 RID: 1299
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Write_Public_UInt32_UInt32_T_0, Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020000A9 RID: 169
			private sealed class MethodInfoStoreGeneric_Reserve_Public_UInt32_UInt32_0<T>
			{
				// Token: 0x04000514 RID: 1300
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Reserve_Public_UInt32_UInt32_0, Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020000AA RID: 170
			private sealed class MethodInfoStoreGeneric_Write_Public_UInt32_Il2CppArrayBase_1_T_Boolean_0<T>
			{
				// Token: 0x04000515 RID: 1301
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Write_Public_UInt32_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020000AB RID: 171
			private sealed class MethodInfoStoreGeneric_Write_Public_UInt32_UInt32_Il2CppArrayBase_1_T_Boolean_0<T>
			{
				// Token: 0x04000516 RID: 1302
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_Write_Public_UInt32_UInt32_Il2CppArrayBase_1_T_Boolean_0, Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}

			// Token: 0x020000AC RID: 172
			private sealed class MethodInfoStoreGeneric_WriteObjects_Public_UInt32_IEnumerable_1_T_Boolean_0<T>
			{
				// Token: 0x04000517 RID: 1303
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BinaryStorageBuffer.Writer.NativeMethodInfoPtr_WriteObjects_Public_UInt32_IEnumerable_1_T_Boolean_0, Il2CppClassPointerStore<BinaryStorageBuffer.Writer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}
	}
}
