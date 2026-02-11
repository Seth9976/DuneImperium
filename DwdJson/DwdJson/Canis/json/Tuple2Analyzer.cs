using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Reflection;

namespace Canis.json
{
	// Token: 0x0200000B RID: 11
	public sealed class Tuple2Analyzer : DwdTypeAnalyzer
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00003B80 File Offset: 0x00001D80
		// Note: this type is marked as 'beforefieldinit'.
		static Tuple2Analyzer()
		{
			Il2CppClassPointerStore<Tuple2Analyzer>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "Tuple2Analyzer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tuple2Analyzer>.NativeClassPtr);
			Tuple2Analyzer.NativeFieldInfoPtr_tupleLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tuple2Analyzer>.NativeClassPtr, "tupleLookup");
			Tuple2Analyzer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple2Analyzer>.NativeClassPtr, 100663328);
			Tuple2Analyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple2Analyzer>.NativeClassPtr, 100663329);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003BEC File Offset: 0x00001DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248383, XrefRangeEnd = 1248407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tuple2Analyzer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tuple2Analyzer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple2Analyzer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003C28 File Offset: 0x00001E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248407, XrefRangeEnd = 1248412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Analyze(DwdModelAnalyzer analyzer, MorePeekableStream tokens, Type targetType, out Object result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(analyzer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Tuple2Analyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000226D File Offset: 0x0000046D
		public Tuple2Analyzer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00003CC0 File Offset: 0x00001EC0
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002276 File Offset: 0x00000476
		public unsafe ConcurrentDictionary<Type, Tuple2Analyzer.TupleInfo> tupleLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple2Analyzer.NativeFieldInfoPtr_tupleLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<Type, Tuple2Analyzer.TupleInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple2Analyzer.NativeFieldInfoPtr_tupleLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_tupleLookup;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0;

		// Token: 0x02000023 RID: 35
		public class TupleInfo : Object
		{
			// Token: 0x06000118 RID: 280 RVA: 0x00006630 File Offset: 0x00004830
			// Note: this type is marked as 'beforefieldinit'.
			static TupleInfo()
			{
				Il2CppClassPointerStore<Tuple2Analyzer.TupleInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tuple2Analyzer>.NativeClassPtr, "TupleInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tuple2Analyzer.TupleInfo>.NativeClassPtr);
				Tuple2Analyzer.TupleInfo.NativeFieldInfoPtr_ConstructorInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tuple2Analyzer.TupleInfo>.NativeClassPtr, "ConstructorInfo");
				Tuple2Analyzer.TupleInfo.NativeFieldInfoPtr_FirstType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tuple2Analyzer.TupleInfo>.NativeClassPtr, "FirstType");
				Tuple2Analyzer.TupleInfo.NativeFieldInfoPtr_SecondType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tuple2Analyzer.TupleInfo>.NativeClassPtr, "SecondType");
				Tuple2Analyzer.TupleInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple2Analyzer.TupleInfo>.NativeClassPtr, 100663330);
			}

			// Token: 0x06000119 RID: 281 RVA: 0x000066AC File Offset: 0x000048AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248376, XrefRangeEnd = 1248383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TupleInfo(Type tupleType)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tuple2Analyzer.TupleInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tupleType);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple2Analyzer.TupleInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600011A RID: 282 RVA: 0x0000270E File Offset: 0x0000090E
			public TupleInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x0600011B RID: 283 RVA: 0x000066F8 File Offset: 0x000048F8
			// (set) Token: 0x0600011C RID: 284 RVA: 0x00002717 File Offset: 0x00000917
			public unsafe ConstructorInfo ConstructorInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple2Analyzer.TupleInfo.NativeFieldInfoPtr_ConstructorInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple2Analyzer.TupleInfo.NativeFieldInfoPtr_ConstructorInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x0600011D RID: 285 RVA: 0x00006728 File Offset: 0x00004928
			// (set) Token: 0x0600011E RID: 286 RVA: 0x00002736 File Offset: 0x00000936
			public unsafe Type FirstType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple2Analyzer.TupleInfo.NativeFieldInfoPtr_FirstType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple2Analyzer.TupleInfo.NativeFieldInfoPtr_FirstType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x0600011F RID: 287 RVA: 0x00006758 File Offset: 0x00004958
			// (set) Token: 0x06000120 RID: 288 RVA: 0x00002755 File Offset: 0x00000955
			public unsafe Type SecondType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple2Analyzer.TupleInfo.NativeFieldInfoPtr_SecondType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tuple2Analyzer.TupleInfo.NativeFieldInfoPtr_SecondType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000A2 RID: 162
			private static readonly IntPtr NativeFieldInfoPtr_ConstructorInfo;

			// Token: 0x040000A3 RID: 163
			private static readonly IntPtr NativeFieldInfoPtr_FirstType;

			// Token: 0x040000A4 RID: 164
			private static readonly IntPtr NativeFieldInfoPtr_SecondType;

			// Token: 0x040000A5 RID: 165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
		}
	}
}
