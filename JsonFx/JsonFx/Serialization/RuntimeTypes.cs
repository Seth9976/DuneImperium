using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace JsonFx.Serialization
{
	// Token: 0x0200000C RID: 12
	public static class RuntimeTypes : Object
	{
		// Token: 0x06000058 RID: 88 RVA: 0x000051A4 File Offset: 0x000033A4
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeTypes()
		{
			Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "RuntimeTypes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr);
			RuntimeTypes.NativeFieldInfoPtr_ObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "ObjectType");
			RuntimeTypes.NativeFieldInfoPtr_ObjectArrayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "ObjectArrayType");
			RuntimeTypes.NativeFieldInfoPtr_StringType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "StringType");
			RuntimeTypes.NativeFieldInfoPtr_IDictionaryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "IDictionaryType");
			RuntimeTypes.NativeFieldInfoPtr_GenericIDictionaryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "GenericIDictionaryType");
			RuntimeTypes.NativeFieldInfoPtr_GenericDictionaryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "GenericDictionaryType");
			RuntimeTypes.NativeFieldInfoPtr_DefaultIDictionaryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "DefaultIDictionaryType");
			RuntimeTypes.NativeFieldInfoPtr_DefaultDictionaryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "DefaultDictionaryType");
			RuntimeTypes.NativeFieldInfoPtr_GenericNullableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "GenericNullableType");
			RuntimeTypes.NativeFieldInfoPtr_GuidType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "GuidType");
			RuntimeTypes.NativeFieldInfoPtr_DateTimeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "DateTimeType");
			RuntimeTypes.NativeFieldInfoPtr_CharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "CharType");
			RuntimeTypes.NativeFieldInfoPtr_TimeSpanType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "TimeSpanType");
			RuntimeTypes.NativeFieldInfoPtr_LongType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "LongType");
			RuntimeTypes.NativeFieldInfoPtr_IListType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "IListType");
			RuntimeTypes.NativeFieldInfoPtr_GenericIListType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "GenericIListType");
			RuntimeTypes.NativeFieldInfoPtr_IEnumerableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "IEnumerableType");
			RuntimeTypes.NativeFieldInfoPtr_GenericIEnumerableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "GenericIEnumerableType");
			RuntimeTypes.NativeFieldInfoPtr_ICollectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "ICollectionType");
			RuntimeTypes.NativeFieldInfoPtr_GenericICollectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "GenericICollectionType");
			RuntimeTypes.NativeFieldInfoPtr_GenericListType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeTypes>.NativeClassPtr, "GenericListType");
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000220F File Offset: 0x0000040F
		public RuntimeTypes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00005378 File Offset: 0x00003578
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002218 File Offset: 0x00000418
		public unsafe static Type ObjectType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_ObjectType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_ObjectType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000053A0 File Offset: 0x000035A0
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000222A File Offset: 0x0000042A
		public unsafe static Type ObjectArrayType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_ObjectArrayType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_ObjectArrayType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000053C8 File Offset: 0x000035C8
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0000223C File Offset: 0x0000043C
		public unsafe static Type StringType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_StringType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_StringType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000053F0 File Offset: 0x000035F0
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0000224E File Offset: 0x0000044E
		public unsafe static Type IDictionaryType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_IDictionaryType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_IDictionaryType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00005418 File Offset: 0x00003618
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002260 File Offset: 0x00000460
		public unsafe static Type GenericIDictionaryType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_GenericIDictionaryType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_GenericIDictionaryType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00005440 File Offset: 0x00003640
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002272 File Offset: 0x00000472
		public unsafe static Type GenericDictionaryType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_GenericDictionaryType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_GenericDictionaryType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00005468 File Offset: 0x00003668
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002284 File Offset: 0x00000484
		public unsafe static Type DefaultIDictionaryType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_DefaultIDictionaryType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_DefaultIDictionaryType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00005490 File Offset: 0x00003690
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002296 File Offset: 0x00000496
		public unsafe static Type DefaultDictionaryType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_DefaultDictionaryType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_DefaultDictionaryType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000054B8 File Offset: 0x000036B8
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000022A8 File Offset: 0x000004A8
		public unsafe static Type GenericNullableType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_GenericNullableType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_GenericNullableType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000054E0 File Offset: 0x000036E0
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000022BA File Offset: 0x000004BA
		public unsafe static Type GuidType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_GuidType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_GuidType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00005508 File Offset: 0x00003708
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000022CC File Offset: 0x000004CC
		public unsafe static Type DateTimeType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_DateTimeType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_DateTimeType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00005530 File Offset: 0x00003730
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000022DE File Offset: 0x000004DE
		public unsafe static Type CharType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_CharType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_CharType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00005558 File Offset: 0x00003758
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000022F0 File Offset: 0x000004F0
		public unsafe static Type TimeSpanType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_TimeSpanType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_TimeSpanType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00005580 File Offset: 0x00003780
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002302 File Offset: 0x00000502
		public unsafe static Type LongType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_LongType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_LongType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000055A8 File Offset: 0x000037A8
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002314 File Offset: 0x00000514
		public unsafe static Type IListType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_IListType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_IListType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000055D0 File Offset: 0x000037D0
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002326 File Offset: 0x00000526
		public unsafe static Type GenericIListType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_GenericIListType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_GenericIListType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000055F8 File Offset: 0x000037F8
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002338 File Offset: 0x00000538
		public unsafe static Type IEnumerableType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_IEnumerableType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_IEnumerableType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00005620 File Offset: 0x00003820
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0000234A File Offset: 0x0000054A
		public unsafe static Type GenericIEnumerableType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_GenericIEnumerableType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_GenericIEnumerableType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00005648 File Offset: 0x00003848
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000235C File Offset: 0x0000055C
		public unsafe static Type ICollectionType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_ICollectionType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_ICollectionType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00005670 File Offset: 0x00003870
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000236E File Offset: 0x0000056E
		public unsafe static Type GenericICollectionType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_GenericICollectionType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_GenericICollectionType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00005698 File Offset: 0x00003898
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002380 File Offset: 0x00000580
		public unsafe static Type GenericListType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RuntimeTypes.NativeFieldInfoPtr_GenericListType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RuntimeTypes.NativeFieldInfoPtr_GenericListType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_ObjectType;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_ObjectArrayType;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_StringType;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_IDictionaryType;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_GenericIDictionaryType;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_GenericDictionaryType;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_DefaultIDictionaryType;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDictionaryType;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_GenericNullableType;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_GuidType;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_DateTimeType;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_CharType;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_TimeSpanType;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_LongType;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_IListType;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_GenericIListType;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_IEnumerableType;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_GenericIEnumerableType;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_ICollectionType;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_GenericICollectionType;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_GenericListType;
	}
}
