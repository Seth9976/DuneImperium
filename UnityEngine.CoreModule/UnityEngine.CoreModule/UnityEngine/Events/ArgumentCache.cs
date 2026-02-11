using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x020001A2 RID: 418
	[Serializable]
	public class ArgumentCache : Object
	{
		// Token: 0x06001EFE RID: 7934 RVA: 0x0008AA5C File Offset: 0x00088C5C
		// Note: this type is marked as 'beforefieldinit'.
		static ArgumentCache()
		{
			Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "ArgumentCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr);
			ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_ObjectArgument");
			ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_ObjectArgumentAssemblyTypeName");
			ArgumentCache.NativeFieldInfoPtr_m_IntArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_IntArgument");
			ArgumentCache.NativeFieldInfoPtr_m_FloatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_FloatArgument");
			ArgumentCache.NativeFieldInfoPtr_m_StringArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_StringArgument");
			ArgumentCache.NativeFieldInfoPtr_m_BoolArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, "m_BoolArgument");
			ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100667550);
			ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100667551);
			ArgumentCache.NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100667552);
			ArgumentCache.NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100667553);
			ArgumentCache.NativeMethodInfoPtr_get_stringArgument_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100667554);
			ArgumentCache.NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100667555);
			ArgumentCache.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100667556);
			ArgumentCache.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100667557);
			ArgumentCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100667558);
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x0008ABB8 File Offset: 0x00088DB8
		// (set) Token: 0x06001F15 RID: 7957 RVA: 0x0000BCF9 File Offset: 0x00009EF9
		public unsafe Object unityObjectArgument
		{
			[CallerCount(169)]
			[CachedScanResults(RefRangeStart = 282426, RefRangeEnd = 282595, XrefRangeStart = 282426, XrefRangeEnd = 282595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			set
			{
				this.m_ObjectArgument = value;
				this.m_ObjectArgumentAssemblyTypeName = ((value != null) ? value.GetType().AssemblyQualifiedName : String.Empty);
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001F00 RID: 7936 RVA: 0x0008ABF8 File Offset: 0x00088DF8
		public unsafe string unityObjectArgumentAssemblyTypeName
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 318167, RefRangeEnd = 318212, XrefRangeStart = 318167, XrefRangeEnd = 318212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001F01 RID: 7937 RVA: 0x0008AC30 File Offset: 0x00088E30
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x0000BD24 File Offset: 0x00009F24
		public unsafe int intArgument
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 337415, RefRangeEnd = 337422, XrefRangeStart = 337415, XrefRangeEnd = 337422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_IntArgument = value;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001F02 RID: 7938 RVA: 0x0008AC6C File Offset: 0x00088E6C
		// (set) Token: 0x06001F17 RID: 7959 RVA: 0x0000BD2E File Offset: 0x00009F2E
		public unsafe float floatArgument
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 678105, RefRangeEnd = 678110, XrefRangeStart = 678105, XrefRangeEnd = 678105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_FloatArgument = value;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x0008ACA8 File Offset: 0x00088EA8
		// (set) Token: 0x06001F18 RID: 7960 RVA: 0x0000BD38 File Offset: 0x00009F38
		public unsafe string stringArgument
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 318860, RefRangeEnd = 318862, XrefRangeStart = 318860, XrefRangeEnd = 318862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_stringArgument_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this.m_StringArgument = value;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001F04 RID: 7940 RVA: 0x0008ACE0 File Offset: 0x00088EE0
		// (set) Token: 0x06001F19 RID: 7961 RVA: 0x0000BD42 File Offset: 0x00009F42
		public unsafe bool boolArgument
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 337422, RefRangeEnd = 337423, XrefRangeStart = 337422, XrefRangeEnd = 337423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_BoolArgument = value;
			}
		}

		// Token: 0x06001F05 RID: 7941 RVA: 0x0008AD1C File Offset: 0x00088F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 678110, XrefRangeEnd = 678112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F06 RID: 7942 RVA: 0x0008AD50 File Offset: 0x00088F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F07 RID: 7943 RVA: 0x0008AD84 File Offset: 0x00088F84
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x0000BC42 File Offset: 0x00009E42
		public ArgumentCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x0008ADC0 File Offset: 0x00088FC0
		// (set) Token: 0x06001F0A RID: 7946 RVA: 0x0000BC4B File Offset: 0x00009E4B
		public unsafe Object m_ObjectArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x0008ADF0 File Offset: 0x00088FF0
		// (set) Token: 0x06001F0C RID: 7948 RVA: 0x0000BC6A File Offset: 0x00009E6A
		public unsafe string m_ObjectArgumentAssemblyTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x0008AE18 File Offset: 0x00089018
		// (set) Token: 0x06001F0E RID: 7950 RVA: 0x0000BC89 File Offset: 0x00009E89
		public unsafe int m_IntArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_IntArgument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_IntArgument)) = value;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x0008AE40 File Offset: 0x00089040
		// (set) Token: 0x06001F10 RID: 7952 RVA: 0x0000BCA4 File Offset: 0x00009EA4
		public unsafe float m_FloatArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_FloatArgument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_FloatArgument)) = value;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x0008AE68 File Offset: 0x00089068
		// (set) Token: 0x06001F12 RID: 7954 RVA: 0x0000BCBF File Offset: 0x00009EBF
		public unsafe string m_StringArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_StringArgument);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_StringArgument), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x0008AE90 File Offset: 0x00089090
		// (set) Token: 0x06001F14 RID: 7956 RVA: 0x0000BCDE File Offset: 0x00009EDE
		public unsafe bool m_BoolArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_BoolArgument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_BoolArgument)) = value;
			}
		}

		// Token: 0x04001B19 RID: 6937
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectArgument;

		// Token: 0x04001B1A RID: 6938
		private static readonly IntPtr NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName;

		// Token: 0x04001B1B RID: 6939
		private static readonly IntPtr NativeFieldInfoPtr_m_IntArgument;

		// Token: 0x04001B1C RID: 6940
		private static readonly IntPtr NativeFieldInfoPtr_m_FloatArgument;

		// Token: 0x04001B1D RID: 6941
		private static readonly IntPtr NativeFieldInfoPtr_m_StringArgument;

		// Token: 0x04001B1E RID: 6942
		private static readonly IntPtr NativeFieldInfoPtr_m_BoolArgument;

		// Token: 0x04001B1F RID: 6943
		private static readonly IntPtr NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0;

		// Token: 0x04001B20 RID: 6944
		private static readonly IntPtr NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0;

		// Token: 0x04001B21 RID: 6945
		private static readonly IntPtr NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0;

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeMethodInfoPtr_get_stringArgument_Public_get_String_0;

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0;

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
