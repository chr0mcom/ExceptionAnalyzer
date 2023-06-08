﻿#region Magnetic Sense Copyright
//              =====================================================================
//               __  __                        _   _       _____
//              |  \/  |                      | | (_)     / ____|
//              | \  / | __ _  __ _ _ __   ___| |_ _  ___| (___   ___ _ __  ___  ___
//              | |\/| |/ _` |/ _` | '_ \ / _ \ __| |/ __|\___ \ / _ \ '_ \/ __|/ _ \
//              | |  | | (_| | (_| | | | |  __/ |_| | (__ ____) |  __/ | | \__ \  __/
//              |_|  |_|\__,_|\__, |_| |_|\___|\__|_|\___|_____/ \___|_| |_|___/\___|
//                             __/ |
//                            |___/
//              =====================================================================
//      Software: BigfixAIProvider | Package: BigfixAIProvider | File: CodePointer.cs
//       -------------------------------------------------------------------------------------
//             Copyright ©2023        |   Unauthorized copying of this file, via any medium
//           MagneticSense GmbH       |    is strictly prohibited. Permission to use, copy,
//           All Rights Reserved      |      modify and distribute this software and its
//       Proprietary and confidential | documentation without corresponding license are denied
//       -------------------------------------------------------------------------------------
//                            Contact for licensing opportunities
//                  MagneticSense GmbH  |  Kelterstrasse 59  |  72669 Unterensingen
//                  Phone: +49 7022 40590 0     |    E-Mail: info@magnetic-sense.de
//                  Fax: +49 7022 40590 29      |    Website: www.magnetic-sense.de
//                  ---------------------------------------------------------------
#endregion
namespace BigfixAIProvider;

public class CodePointer
{
	public string FullName { get; set; }
	
	public CodeType Type { get; set; }
	
}